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
using System.Net;
using HttpContext = Bixby_web_server.Helpers.HttpContext;

namespace Bixby_web_server.Controllers
{
    public abstract class ShopController
    {
        private static readonly ShopItemService ShopItemService = new ShopItemService();
        private static readonly UserShopService UserShopService = new UserShopService();
        private static readonly CommentService CommentService = new CommentService();
        private static readonly OrderService OrderService = new OrderService();
        private static readonly UserService UserService = new UserService();
        private static readonly ProductPurchasesService productPurchasesService = new ProductPurchasesService();
        public static async Task GetAllTheShopItems(HttpContext context)
        {
            Console.WriteLine(context.Url);
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new
                    { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            var shopItems = await ShopItemService.GetAllShopItemsAsync();
            var convertedItems = shopItems.Select(shop => new ShopAllShopItem
            {
                Id = shop.Id,
                Name = shop.Name,
                PicLowRes = shop.PicLowRes
            }).ToList();

            var response = new
            {
                status = "Success",
                body = convertedItems
            };
            context.ResponseContent = response.ToJson();
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                .ConfigureAwait(false);
        }


        public static async Task ViewOneShopItem(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new
                    { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            if (context.DynamicPath is { Length: > 0 })
            {
                ShopItem shopItem = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath[0]);
                if (shopItem == null)
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                        .ToJson());

                {
                    UserShop userShop = await UserShopService.GetProductByItemId(shopItem.Id);
                    userShop.TotalViews += 1;
                    await UserShopService.ProductUpdateByItemId(userShop.Id, userShop);
                    var response = new
                    {
                        status = "Success",
                        body = shopItem
                    };
                    context.ResponseContent = response.ToJson();
                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
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
            if (context.Request.HttpMethod != "POST")
                throw new MethodNotAllowedException(new
                    { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            var checkMiddleWare = new CheckMiddleWare();
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

            if (!jwt.ContainsKey("jwt"))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());

            if (NullEmptyChecker.HasNullEmptyValues(jwt["jwt"]))
                throw new UnauthorizedException(
                    new { status = "An error occurred.", message = "Unauthorized" }.ToJson());

            string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding)
                .ReadToEndAsync().ConfigureAwait(false);
            
            Dictionary<string, object> validateResult =
                await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

            ShopItem shopItem = (ShopItem)validateResult["data"];

            if (!NullEmptyChecker.HasNullEmptyValues(shopItem))
                throw new BadRequestException(
                    new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            
            ShopItem shopItemByReqId = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath?[1]);
            
            if (shopItemByReqId == null)
                throw new NotFoundException(new
                    { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

            shopItemByReqId.Name = shopItem.Name;
            shopItemByReqId.Description = shopItem.Description;
            shopItemByReqId.Price = shopItem.Price;

            bool isUpdate = await ShopItemService.UpdateShopItemAsync(shopItemByReqId.Id, shopItemByReqId);
            if (!isUpdate)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }
                    .ToJson());
            
            var response = new
            {
                status = "Success",
                message = "ShopItem Updated successfully"
            };

            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                .ConfigureAwait(false);
        }

        public static async Task UploadOneShopItem(HttpContext context)
        {
            var checkMiddleWare = new CheckMiddleWare();

            Dictionary<string, object> jwt =
                await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

            if (!jwt.ContainsKey("jwt"))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());

            if (NullEmptyChecker.HasNullEmptyValues(jwt["jwt"]))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }
                    .ToJson());
            
            string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding)
                .ReadToEndAsync().ConfigureAwait(false);
            Dictionary<string, object> validateResult =
                await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

            ShopItem shopItem = (ShopItem)validateResult["data"];

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

            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                .ConfigureAwait(false);
        }

        public static async Task OneShopItemComment(HttpContext context)
        {
            var checkMiddleWare = new CheckMiddleWare();
            var request = context.Request;
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var shopId = new ObjectId(context.DynamicPath[0]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            switch (context.Request.HttpMethod)
            {
                case "POST" when jwt.TryGetValue("jwt", out var value):
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        JsonSerializerSettings? settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        };
                        string json = await reader.ReadToEndAsync().ConfigureAwait(false);
                        var commentReq = JsonConvert.DeserializeObject<CommentReq>(json, settings);
                        ShopItem shop = await ShopItemService.GetShopItemByIdAsync(shopId);
                        if (shop == null)
                            throw new NotFoundException(new
                                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                        {
                            User user = (User)value;

                            Comment comment = new Comment();
                            if (commentReq?.UserComment != null) comment.UserComment = commentReq?.UserComment;
                            comment.User = user.Id;
                            comment.ShopItem = shop.Id;
                            if (commentReq != null) comment.rate = commentReq.rate;
                            

                            await CommentService.CreateComment(comment);


                            List<Comment> comments = CommentService.GetAllCommentsByShopItemName(shop.Id);
                            double rate= CommentService.CalculateTotalRating(comments.ToArray().Length, comment.rate);
                            shop.TotalComments += 1;
                            shop.Rating = rate;
                            bool isAck = await ShopItemService.UpdateShopItemAsync(shop.Id, shop);
                            if (isAck)
                            {
                            }
                        }

                        var response = new
                        {
                            status = "Success",
                            message = "Comment added successfully"
                        };

                        await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                            .ConfigureAwait(false);
                    }

                    break;
                }
                case "POST":
                    throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }
                        .ToJson());
                case "GET":
                {
                    List<Comment> comment = CommentService.GetAllCommentsByShopItemName(shopId) ??
                                            throw new NotFoundException(new
                                                    { status = "An error occurred.", message = "Not Found Exception" }
                                                .ToJson());

                    if (comment.IsNullOrEmpty())
                        throw new NotFoundException(
                            new { status = "An error occurred.", message = "Not Found" }.ToJson());
                    
                    var response = new
                    {
                        status = "Success",
                        body = comment
                    };
                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
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
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            String? shopId = context.DynamicPath?[0];
            String? email = context.DynamicPath?[1];

            User? user = await UserService.GetUserByEmailAsync(email);

            if (NullEmptyChecker.HasNullEmptyValues(user))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());

            Dictionary<string, object> jwt =
            await checkMiddleWare.CheckMiddleWareJwt(context, email?.Trim());

            if (!jwt.ContainsKey("jwt"))
                throw new UnauthorizedAccessException(new { status = "An error occurred.", message = "Unauthorized Access Exception" }
                    .ToJson());

            User result = (User)jwt["jwt"];

            if (NullEmptyChecker.HasNullEmptyValues(result))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }
                    .ToJson());

            ShopItem shopItem = await ShopItemService.GetShopItemByIdAsync(shopId);

            ObjectId[] items = { shopItem.Id };

            Order order = new Order {
                Items = items,
                Price = shopItem.Price,
                User = user.Email,
                Confirm = false
            };

            await OrderService.CreateOrder(order);

#pragma warning disable CS8601 // Possible null reference assignment.
            ProductPurchases productPurchases = new ProductPurchases
            {
                orderId = order.Id,
                cutomerId = user.Id,
                ownerId = shopItem.publish.Email
            };
#pragma warning restore CS8601 // Possible null reference assignment.

           await productPurchasesService.CreateProductPurchaseAsync(productPurchases);

            var response = new
            {
                status = "Success",
            };
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                .ConfigureAwait(false);
        }
    }
}