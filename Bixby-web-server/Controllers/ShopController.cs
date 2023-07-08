using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Comments.Services;
using BixbyShop_LK.Models.Item.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;
using SendGrid.Helpers.Errors.Model;

namespace Bixby_web_server.Controllers;

public abstract class ShopController
{
    private static readonly ShopItemService ShopItemService = new();
    private static readonly UserShopService UserShopService = new();
    private static readonly CommentService CommentService = new();
    private static readonly OrderService OrderService = new();
    private static readonly UserService UserService = new();
    private static readonly ProductPurchasesService ProductPurchasesService = new();

    public static async Task GetAllTheShopItems(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new
                { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

        if (RedisCache.Get("all-items") != null)
            await context.WriteResponse(RedisCache.Get("all-items"), "application/json")
                .ConfigureAwait(false);

        var shopItems = await ShopItemService.GetAllShopItemsAsync();
        var convertedItems = shopItems.Select(shop => new ShopAllShopItem
        {
            Id = shop.Id.ToString(),
            Name = shop.Name,
            PicLowRes = shop.Pics.Length > 0 ? shop.Pics[0] : ""
        }).ToList();

        var response = new
        {
            status = "Success",
            body = convertedItems
        };
        RedisCache.Set("all-items", response.ToJson());
        context.ResponseContent = response.ToJson();
        await context.WriteResponse(response.ToJson(), "application/json")
            .ConfigureAwait(false);
    }


    public static async Task ViewOneShopItem(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new
                { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

        if (context.DynamicPath is { Length: > 0 })
        {
            if (RedisCache.Get("item-" + context.DynamicPath[0]) != null)
                await context.WriteResponse(RedisCache.Get("item-" + context.DynamicPath[0]), "application/json")
                    .ConfigureAwait(false);

            var shopItem = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath[0]);
            if (shopItem == null)
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());

            {
                var userShop = await UserShopService.GetProductByItemId(shopItem.Id);
                userShop.TotalViews += 1;
                await UserShopService.ProductUpdateByItemId(userShop.Id, userShop);
                var response = new
                {
                    status = "Success",
                    body = new
                    {
                        id = shopItem.Id.ToString(),
                        shopItem.Name,
                        shopItem.Description,
                        TotalComments = (int)shopItem.TotalComments,
                        shopItem.Price,
                        shopItem.Pics,
                        shopItem.publish,
                        shopItem.loveThisProduct
                    }
                };
                RedisCache.Set("item-" + context.DynamicPath[0], response.ToJson());
                context.ResponseContent = response.ToJson();
                await context.WriteResponse(response.ToJson(), "application/json")
                    .ConfigureAwait(false);
            }
        }
        else
        {
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
        }
    }

    public static async Task UpdateOneShopItem(HttpContext context)
    {
        if (context.Request.HttpMethod != "PUT" || context.Request.HttpMethod != "PATCH")
            throw new MethodNotAllowedException(new
                { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

        if (!jwt.ContainsKey("jwt"))
            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                .ToJson());

        if (NullEmptyChecker.HasNullEmptyValues(jwt["jwt"]))
            throw new UnauthorizedException(
                new { status = "An error occurred.", message = "Unauthorized" }.ToJson());

        var json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding)
            .ReadToEndAsync().ConfigureAwait(false);

        var validateResult =
            await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

        var shopItem = (ShopItem)validateResult["data"];

        if (!NullEmptyChecker.HasNullEmptyValues(shopItem))
            throw new BadRequestException(
                new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var shopItemByReqId = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath?[1]);

        if (shopItemByReqId == null)
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

        shopItemByReqId.Name = shopItem.Name;
        shopItemByReqId.Description = shopItem.Description;
        shopItemByReqId.Price = shopItem.Price;

        var isUpdate = await ShopItemService.UpdateShopItemAsync(shopItemByReqId.Id, shopItemByReqId);
        if (!isUpdate)
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }
                .ToJson());

        var response = new
        {
            status = "Success",
            message = "ShopItem Updated successfully"
        };
        RedisCache.Set("item-" + context.DynamicPath[0], response.ToJson());
        RedisCache.Remove("all-items");
        await context.WriteResponse(response.ToJson(), "application/json")
            .ConfigureAwait(false);
    }

    public static async Task UploadOneShopItem(HttpContext context)
    {
        if (context.Request.HttpMethod != "POST")
            throw new MethodNotAllowedException(new
                { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());
        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (!NullEmptyChecker.HasNullEmptyValues(result))
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());


        var json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding)
            .ReadToEndAsync().ConfigureAwait(false);

        var validateResult =
            await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

        var shopItem = (ShopItem)validateResult["data"];

        if (NullEmptyChecker.HasNullEmptyValues(shopItem))
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }
                .ToJson());

        await ShopItemService.CreateShopItemAsync(shopItem);

        await UserShopService.AddProduct(shopItem.publish.Email, shopItem.Id);

        var response = new
        {
            status = "Success",
            message = "ShopItem added successfully"
        };

        await context.WriteResponse(response.ToJson(), "application/json")
            .ConfigureAwait(false);
    }

    public static async Task OneShopItemComment(HttpContext context)
    {
        var checkMiddleWare = new CheckMiddleWare();
        var request = context.Request;
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        var shopId = new ObjectId(context.DynamicPath[0]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        switch (context.Request.HttpMethod)
        {
            case "POST" when jwt.TryGetValue("jwt", out var value):
            {
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };
                    var json = await reader.ReadToEndAsync().ConfigureAwait(false);
                    var commentReq = JsonConvert.DeserializeObject<CommentReq>(json, settings);
                    var shop = await ShopItemService.GetShopItemByIdAsync(shopId);
                    if (shop == null)
                        throw new NotFoundException(new
                            { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                    var user = (User)value;
                    {
                        var comment = new Comment();
                        if (commentReq?.UserComment != null) comment.UserComment = commentReq?.UserComment;
                        comment.User = user.Id;
                        comment.ShopItem = shop.Id;

                        await CommentService.CreateComment(comment);


                        var comments = CommentService.GetAllCommentsByShopItemName(shop.Id);
                        shop.TotalComments += 1;
                        var isAck = await ShopItemService.UpdateShopItemAsync(shop.Id, shop);
                        if (isAck)
                        {
                        }
                    }

                    var response = new
                    {
                        status = "Success",
                        message = "Comment added successfully"
                    };
                    RedisCache.Remove("comment-user-" + user.Email);
                    RedisCache.Remove("comment-" + shopId);

                    await context.WriteResponse(response.ToJson(), "application/json")
                        .ConfigureAwait(false);
                }

                break;
            }
            case "POST":
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }
                    .ToJson());
            case "GET":
            {
                if (RedisCache.Get("comment-" + shopId) != null)
                    await context.WriteResponse(RedisCache.Get("commend-" + shopId), "application/json")
                        .ConfigureAwait(false);

                var comment = CommentService.GetAllCommentsByShopItemName(shopId) ??
                              throw new NotFoundException(new
                                      { status = "An error occurred.", message = "Not Found Exception" }
                                  .ToJson());

                if (comment.IsNullOrEmpty())
                    throw new NotFoundException(
                        new { status = "An error occurred.", message = "Not Found" }.ToJson());

                var response = new
                {
                    status = "Success",
                    body = comment.ConvertAll(input =>
                    {
                        if (input.UserComment != null)
                        {
                            var commentRes = new CommentRes(input.Id.ToString(), input.UserComment,
                                input.User.ToString(), input.ShopItem.ToString());
                            return commentRes;
                        }

                        return null;
                    })
                };
                RedisCache.Set("comment-" + shopId, response.ToJson());
                await context.WriteResponse(response.ToJson(), "application/json")
                    .ConfigureAwait(false);

                break;
            }
            default:
                throw new MethodNotAllowedException(new
                    { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
        }
    }

    internal static async Task BuyItem(HttpContext context)
    {
        var checkMiddleWare = new CheckMiddleWare();
        var shopId = context.DynamicPath?[0];
        var email = context.DynamicPath?[1];

        var user = await UserService.GetUserByEmailAsync(email);

        if (NullEmptyChecker.HasNullEmptyValues(user))
            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                .ToJson());

        var jwt =
            await checkMiddleWare.CheckMiddleWareJwt(context, email?.Trim());

        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (!NullEmptyChecker.HasNullEmptyValues(result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());
        var shopItem = await ShopItemService.GetShopItemByIdAsync(shopId);

        ObjectId[] items = { shopItem.Id };

        var order = new Order
        {
            Items = items,
            Price = shopItem.Price,
            User = user.Email,
            Confirm = false
        };

        await OrderService.CreateOrder(order);

#pragma warning disable CS8601 // Possible null reference assignment.
        var productPurchases = new ProductPurchases
        {
            orderId = order.Id,
            cutomerId = user.Id,
            ownerId = shopItem.publish.Email
        };
#pragma warning restore CS8601 // Possible null reference assignment.

        await ProductPurchasesService.CreateProductPurchaseAsync(productPurchases);

        var response = new
        {
            status = "Success"
        };
        RedisCache.Remove("User-SeePurchase-" + email);
        RedisCache.Remove(email + "-order");
        await context.WriteResponse(response.ToJson(), "application/json")
            .ConfigureAwait(false);
    }
}