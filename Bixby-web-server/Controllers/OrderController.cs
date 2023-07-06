using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;
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
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());
        var jwt =
            await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());

        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (NullEmptyChecker.HasNullEmptyValues(result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

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

        if (RedisCache.Get(email + "-order") != null)
            await context.WriteResponse(RedisCache.Get(email + "-order"), "application/json").ConfigureAwait(false);


        var user = await GetUser(checkMiddleWare, email, context);
        var orders = OrderService.GetAllOrders(user?.Email);

        if (orders.IsNullOrEmpty())
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }
                .ToJson());

        var response = new
        {
            status = "Success",
            data = orders.ToArray()
        };
        context.ResponseContent = response.ToJson();
        RedisCache.Set(email + "-order", response.ToJson());
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }
}