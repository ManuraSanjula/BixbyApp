using System.Net;
using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Item.Services;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using SendGrid.Helpers.Errors.Model;

namespace Bixby_web_server.Controllers
{
    public class CartRes
    {
        public List<CartAndOrder> cartAndOrder { get; set; }
        public User User { get; set; }
    }
    public abstract class CartController
    {
        private static readonly ShopItemService ShopItemService = new ShopItemService();
        private static readonly CartAndOrderService CartAndOrderService = new CartAndOrderService();
        private static readonly UserService UserService = new UserService();
        private static readonly UserShopService UserShopService = new UserShopService();
        private static readonly OrderService OrderService = new OrderService();
        private static readonly ProductPurchasesService productPurchasesService = new ProductPurchasesService();

        static async Task<CartRes> CartAndOrders(HttpContext httpContext, CheckMiddleWare checkMiddleWare, string? email)
            {
                if (checkMiddleWare == null) throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                    .ToJson());
                
                if (email == null) throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                    .ToJson());
                
                if (httpContext.Request.HttpMethod != "GET")
                    throw new MethodNotAllowedException(
                        new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

                checkMiddleWare = new CheckMiddleWare();
                email = httpContext.DynamicPath?[0];
                User? user = await UserService.GetUserByEmailAsync(email);

                if (NullEmptyChecker.HasNullEmptyValues(user))
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                        .ToJson());

                Dictionary<string, object> jwt =
                    await checkMiddleWare.CheckMiddleWareJwt(httpContext, httpContext.DynamicPath?[0]?.Trim());

                if (!jwt.ContainsKey("jwt"))
                    throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                        .ToJson());

                User result = (User)jwt["jwt"];

                if (NullEmptyChecker.HasNullEmptyValues(result))
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                        .ToJson());

                if (object.Equals(result, user))
                    throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                        .ToJson());

                IAsyncCursor<CartAndOrder> asyncCursor = await CartAndOrderService.GetAllCartAndOrders(user?.Email);
                return new CartRes
                {
                   User = user,
                   cartAndOrder = await asyncCursor.ToListAsync(),
                };
            }

        public static async Task SeeAllTheCart(HttpContext arg)
        {
            if (arg.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            string? email = arg.DynamicPath?[0];
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();

            CartRes cartAndOrders = await CartAndOrders(arg, checkMiddleWare, email);

            if (cartAndOrders.User.Email != null && !cartAndOrders.User.Email.Equals(email))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson()); 

            if (!NullEmptyChecker.HasNullEmptyValues(cartAndOrders.cartAndOrder))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            var response = new
            {
                status = "Success",
                data = cartAndOrders.cartAndOrder
            };
            await arg.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task AddToCart(HttpContext arg)
        {
            if (arg.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            
            string? email = arg.DynamicPath?[0];
            string? shopId = arg.DynamicPath?[0];
            
            User? user = await UserService.GetUserByEmailAsync(email);
            ShopItem? shopItem = await ShopItemService.GetShopItemByIdAsync(shopId);
            
            if(NullEmptyChecker.HasNullEmptyValues(user) || NullEmptyChecker.HasNullEmptyValues(shopItem))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

            int? pathParam =  int.Parse(arg.Request.QueryString["Quantity"]?.ToString() ?? string.Empty);
            if (pathParam == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }.ToJson());   
            
            CartAndOrder cartAndOrder = new CartAndOrder
            {
                User = user?.Email,
                Item = shopItem.Id,
                Price = shopItem.Price * pathParam.Value,
                Quantity = pathParam.Value
            };
            
            await CartAndOrderService.CreateCartAndOrder(cartAndOrder);
            var response = new
            {
                status = "Success",
                message = "Successfully added to the cart"
            };
            await arg.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task CheckOutAllItems(HttpContext arg)
        {
            if (arg.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            string? email = arg.DynamicPath?[0];
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();

            CartRes cartAndOrders = await CartAndOrders(arg, checkMiddleWare, email);

            if (cartAndOrders.User.Email != null && !cartAndOrders.User.Email.Equals(email))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            if (!NullEmptyChecker.HasNullEmptyValues(cartAndOrders.cartAndOrder))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            Order order = new Order();

            List<CartAndOrder> cartAndOrdersList = cartAndOrders.cartAndOrder;
            List<ObjectId> items = new List<ObjectId>();

            cartAndOrdersList.ForEach(cartAndOrder =>
            {
                items.Add(cartAndOrder.Id);
                order.Price += cartAndOrder.Price;
            });

            items.ForEach(id =>
            {
                UserShopService.CalculateShopAnalytics(id);
            });

            order.Items = items.ToArray();
            order.User = cartAndOrders.User.Email;

            if(!OrderService.CreateOrder(order).IsCompletedSuccessfully)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            ShopItem item = await ShopItemService.GetShopItemByIdAsync(order.Id);

#pragma warning disable CS8601 // Possible null reference assignment.
            ProductPurchases productPurchases = new ProductPurchases
            {
                orderId = order.Id,
                cutomerId = cartAndOrdersList[0].Id,
                ownerId = item.publish.Email
            };
#pragma warning restore CS8601 // Possible null reference assignment.

            await productPurchasesService.CreateProductPurchaseAsync(productPurchases);

            var response = new
            {
                status = "Success",
                message = "Successfully CheckOut"
            };

            await arg.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }
    }
}
