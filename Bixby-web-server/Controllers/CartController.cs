using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Item.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using SendGrid.Helpers.Errors.Model;

namespace Bixby_web_server.Controllers;

public class CartRes
{
    public List<CartAndOrder> cartAndOrder { get; set; }
    public User User { get; set; }
}

public abstract class CartController
{
    private static readonly ShopItemService ShopItemService = new();
    private static readonly CartAndOrderService CartAndOrderService = new();
    private static readonly UserService UserService = new();
    private static readonly OrderService OrderService = new();
    private static readonly ProductPurchasesService productPurchasesService = new();

    private static async Task<CartRes> CartAndOrders(HttpContext httpContext, CheckMiddleWare checkMiddleWare,
        string? email)
    {
        if (checkMiddleWare == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        if (email == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        if (httpContext.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(
                new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

        checkMiddleWare = new CheckMiddleWare();
        email = httpContext.DynamicPath?[0];
        User? user;
        user = JsonConvert.DeserializeObject<User>(RedisCache.Get(email));
        if (user == null)
        {
            user = await UserService.GetUserByEmailAsync(email);
            RedisCache.Set(user.Email, user.ToJson());
        }
        else
        {
            var user_db = await UserService.GetUserByEmailAsync(email);
            if (!user.Equals(user_db))
            {
                user = user_db;
                RedisCache.Set(user.Email, user.ToJson());
            }
        }

        if (NullEmptyChecker.HasNullEmptyValues(user))
            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                .ToJson());

        var jwt =
            await checkMiddleWare.CheckMiddleWareJwt(httpContext, httpContext.DynamicPath?[0]?.Trim());

        if (!jwt.ContainsKey("jwt"))
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (NullEmptyChecker.HasNullEmptyValues(result))
            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                .ToJson());

        if (Equals(result, user))
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        var asyncCursor = await CartAndOrderService.GetAllCartAndOrders(user?.Email);
        return new CartRes
        {
            User = user,
            cartAndOrder = await asyncCursor.ToListAsync()
        };
    }

    public static async Task SeeAllTheCart(HttpContext arg)
    {
        if (arg.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = arg.DynamicPath?[0];

        if (RedisCache.Get(email + "-cart") != null)
            await arg.WriteResponse(RedisCache.Get(email + "-cart"), "application/json").ConfigureAwait(false);

        var checkMiddleWare = new CheckMiddleWare();

        var cartAndOrders = await CartAndOrders(arg, checkMiddleWare, email);

        if (cartAndOrders.User.Email != null && !cartAndOrders.User.Email.Equals(email))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "UnauthorizedException" }
                .ToJson());

        if (NullEmptyChecker.HasNullEmptyValues(cartAndOrders))
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        if (cartAndOrders.cartAndOrder.IsNullOrEmpty())
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var response = new
        {
            status = "Success",
            data = cartAndOrders.cartAndOrder
        };
        RedisCache.Set(email + "-cart", response.ToJson());
        arg.ResponseContent = response.ToJson();
        await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task AddToCart(HttpContext arg)
    {
        if (arg.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = arg.DynamicPath?[0];
        var shopId = arg.DynamicPath?[1];

        User? user;
        user = JsonConvert.DeserializeObject<User>(RedisCache.Get(email));
        if (user == null)
        {
            user = await UserService.GetUserByEmailAsync(email);
            RedisCache.Set(user.Email, user.ToJson());
        }
        else
        {
            var user_db = await UserService.GetUserByEmailAsync(email);
            if (!user.Equals(user_db))
            {
                user = user_db;
                RedisCache.Set(user.Email, user.ToJson());
            }
        }

        var shopItem = await ShopItemService.GetShopItemByIdAsync(shopId);

        if (NullEmptyChecker.HasNullEmptyValues(user) || NullEmptyChecker.HasNullEmptyValues(shopItem))
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

        int? pathParam = int.Parse(arg.Request.QueryString["Quantity"] ?? string.Empty);
        if (pathParam == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        var cartAndOrder = new CartAndOrder
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
        await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task CheckOutAllItems(HttpContext arg)
    {
        if (arg.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = arg.DynamicPath?[0];
        var checkMiddleWare = new CheckMiddleWare();

        var cartAndOrders = await CartAndOrders(arg, checkMiddleWare, email);

        if (cartAndOrders.User.Email != null && !cartAndOrders.User.Email.Equals(email))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "UnauthorizedException" }
                .ToJson());

        if (NullEmptyChecker.HasNullEmptyValues(cartAndOrders))
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        if (cartAndOrders.cartAndOrder.IsNullOrEmpty())
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var order = new Order();

        var cartAndOrdersList = cartAndOrders.cartAndOrder;
        var items = new List<ObjectId>();

        cartAndOrdersList.ForEach(cartAndOrder =>
        {
            items.Add(cartAndOrder.Id);
            order.Price += cartAndOrder.Price;
        });
        order.Items = items.ToArray();
        order.User = cartAndOrders.User.Email;

        await OrderService.CreateOrder(order);


#pragma warning disable CS8601 // Possible null reference assignment.
        var productPurchases = new ProductPurchases
        {
            orderId = order.Id,
            cutomerId = cartAndOrdersList[0].Id,
            ownerId = email
        };
#pragma warning restore CS8601 // Possible null reference assignment.

        await productPurchasesService.CreateProductPurchaseAsync(productPurchases);
        cartAndOrdersList.ForEach(i => CartAndOrderService.DeleteCartAndOrder(i.Id));
        var response = new
        {
            status = "Success",
            message = "Successfully CheckOut"
        };
        RedisCache.Remove("User-SeePurchase-" + email);
        await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }
}