using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;

namespace Bixby_web_server.Controllers;

public abstract class OrderController
{
    private static readonly OrderService OrderService = new();
    private static readonly UserService UserService = new();
    private static readonly ProductPurchasesService ProductPurchasesService = new();

    private static async Task<User?> GetUser(CheckMiddleWare checkMiddleWare, string? email, HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(
                new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

        var user = await UserService.GetUserByEmailAsync(email);
        ;

        /*if (NullEmptyChecker.HasNullEmptyValues(user))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());*/
        var jwt =
            await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());

        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        /*if (NullEmptyChecker.HasNullEmptyValues(result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());*/

        if (Equals(result, user))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());
        return user;
    }

    internal static async Task ConfirmTheOrder(HttpContext context)
    {
        var checkMiddleWare = new CheckMiddleWare();
        var email = context.DynamicPath?[0];
        var orderId = context.DynamicPath?[1];

        var user = await GetUser(checkMiddleWare, email, context);
        var order = OrderService.GetOrderById(new ObjectId(orderId));

        if (user != null && !order.User.Equals(user.Email))
            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                .ToJson());

        if (NullEmptyChecker.HasNullEmptyValues(order))
            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                .ToJson());

        order.Confirm = true;
        OrderService.UpdateOrder(order.Id, order);

        var productPurchases = await ProductPurchasesService.GetProductPurchasesByOrderIdAsync(order.Id);
        productPurchases.isDeliverd = true;
        await ProductPurchasesService.UpdateProductPurchaseAsync(productPurchases.Id, productPurchases);
        await context.WriteResponse(new { status = "Success" }
            .ToJson(), "application/json").ConfigureAwait(false);
    }

    internal static Task Refund(HttpContext context)
    {
        throw new NotImplementedException();
    }

    internal static async Task SeeAllOrders(HttpContext context)
    {
        var checkMiddleWare = new CheckMiddleWare();
        var email = context.DynamicPath?[0];
        var user = await GetUser(checkMiddleWare, email, context);
        var orders = OrderService.GetAllOrders(user?.Email);

        if (orders.IsNullOrEmpty())
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }
                .ToJson());

        var response = new
        {
            status = "Success",
            data = orders.ConvertAll(order =>
            {
                return new
                {
                    Id = order.Id.ToString(),
                    Items = new List<ObjectId>(order.Items).ConvertAll(id => id.ToString()),
                    order.User,
                    order.Price,
                    order.Confirm
                };
            })
        };
        context.ResponseContent = response.ToJson();
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }
}