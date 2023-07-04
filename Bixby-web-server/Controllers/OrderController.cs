using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;
using System.Net;
using HttpContext = Bixby_web_server.Helpers.HttpContext;

namespace Bixby_web_server.Controllers
{
    public abstract class OrderController
    {
        private static readonly OrderService OrderService = new OrderService();
        private static readonly UserService UserService = new UserService();
        private static readonly ProductPurchasesService ProductPurchasesService = new ProductPurchasesService();

        private static async Task<User?> GetUser(CheckMiddleWare checkMiddleWare,string? email,HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(
                    new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            User? user = await UserService.GetUserByEmailAsync(email);

            if (NullEmptyChecker.HasNullEmptyValues(user))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                    .ToJson());
            Dictionary<string, object> jwt =
                await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());

            if (!jwt.ContainsKey("jwt"))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                   .ToJson());

            User result = (User)jwt["jwt"];

            if (NullEmptyChecker.HasNullEmptyValues(result))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                   .ToJson());

            if (object.Equals(result, user))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                    .ToJson());
            return user;
        }
        internal static async Task ConfirmTheOrder(HttpContext context)
        {
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            string? email = context.DynamicPath?[0];
            string? orderId = context.DynamicPath?[1];

            User? user = await GetUser(checkMiddleWare, email, context);
            Order order = OrderService.GetOrderById(new ObjectId(orderId));
            
            if(user != null && !order.User.Equals(user.Email))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());
            
            if (NullEmptyChecker.HasNullEmptyValues(order))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());
            
            order.Confirm = true;
            OrderService.UpdateOrder(order.Id, order);

            ProductPurchases productPurchases = await ProductPurchasesService.GetProductPurchasesByOrderIdAsync(order.Id);
            productPurchases.isDeliverd = true;
            await ProductPurchasesService.UpdateProductPurchaseAsync(productPurchases.Id, productPurchases);
            await context.WriteResponse(new { status = "Success"}
                .ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }
        internal static Task Refund(HttpContext context)
        {
            throw new NotImplementedException();
        }

        internal static async Task SeeAllOrders(HttpContext context)
        {
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            string? email = context.DynamicPath?[0];

            User? user = await GetUser(checkMiddleWare, email, context);
            List<Order> orders = OrderService.GetAllOrders(user?.Email);

            if (orders.IsNullOrEmpty())
                throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                    .ToJson());
            
            var response = new
            {
                status = "Success",
                data = orders.ToArray()
            };
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }
    }
}
