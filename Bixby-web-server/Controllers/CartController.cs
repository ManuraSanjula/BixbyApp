using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Item.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using MongoDB.Driver;
using SendGrid.Helpers.Errors.Model;

namespace Bixby_web_server.Controllers;

public class CartRes
{
    public List<Cart> cartAndOrder { get; set; }
    public User User { get; set; }
}

public abstract class CartController
{
    private static readonly ShopItemService ShopItemService = new();
    private static readonly CartService CartService = new();
    private static readonly UserService UserService = new();
    private static readonly OrderService OrderService = new();
    private static readonly ProductPurchasesService ProductPurchasesService = new();

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
        var user = await UserService.GetUserByEmailAsync(email);

        var jwt =
            await checkMiddleWare.CheckMiddleWareJwt(httpContext, httpContext.DynamicPath?[0]?.Trim());

        if (!jwt.ContainsKey("jwt"))
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (Equals(result, user))
            throw new BadRequestException(new { status = "An error occurred.", message = "Bad Request Exception" }
                .ToJson());

        var asyncCursor = await CartService.GetAllCartAndOrders(user?.Email);
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
            data = cartAndOrders.cartAndOrder.ConvertAll(cart =>
            {
                var res = new
                {
                    Id = cart.Id.ToString(),
                    Item = cart.Item.ToString(),
                    cart.User,
                    cart.Quantity,
                    cart.Price
                };
                return res;
            })
        };
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


        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(arg, email?.Trim());
        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (!NullEmptyChecker.HasNullEmptyValues(result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());


        var shopItem = await ShopItemService.GetShopItemByIdAsync(shopId);
        if (NullEmptyChecker.HasNullEmptyValues(shopItem))
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

        var cart = await CartService.GetCartAndOrderByItem(new ObjectId(shopId));
        if (cart != null && cart.User.Equals(result?.Email))
        {
            cart.Price = cart.Price + shopItem.Price;
            cart.Quantity += 1;
            CartService.UpdateCartAndOrder(cart.Id, cart);
            await arg.WriteResponse(new
            {
                status = "Success",
                message = "Successfully added to the cart"
            }.ToJson(), "application/json").ConfigureAwait(false);
        }
        else
        {
            int? pathParam = int.Parse(arg.Request.QueryString["Quantity"] ?? string.Empty);
            if (pathParam == 0) pathParam = 1;

            var cartAndOrder = new Cart
            {
                User = result?.Email,
                Item = shopItem.Id,
                Price = shopItem.Price * pathParam.Value,
                Quantity = pathParam.Value
            };

            await CartService.CreateCartAndOrder(cartAndOrder);
            var response = new
            {
                status = "Success",
                message = "Successfully added to the cart"
            };
            await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
        }
    }

    public static async Task CheckOutAllItems(HttpContext arg)
    {
        if (arg.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = arg.DynamicPath?[0];
        var checkMiddleWare = new CheckMiddleWare();

        var cartAndOrders = await CartAndOrders(arg, checkMiddleWare, email);

        if (cartAndOrders.User == null)
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

        await ProductPurchasesService.CreateProductPurchaseAsync(productPurchases);
        cartAndOrdersList.ForEach(i => CartService.DeleteCartAndOrder(i.Id));
        var response = new
        {
            status = "Success",
            message = "Successfully CheckOut"
        };
        await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task DeleteCart(HttpContext arg)
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

        var find = cartAndOrders.cartAndOrder.Find(c => c.Id == new ObjectId(arg.DynamicPath?[1]));

        if (find != null)
        {
            CartService.DeleteCartAndOrder(find.Id);
            var response = new
            {
                status = "Success"
            };
            await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
        }
        else
        {
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
        }
    }
}