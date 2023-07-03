using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Comments.Services;
using BixbyShop_LK.Models.Item.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;
using SendGrid.Helpers.Errors.Model;
using System.Net;

namespace Bixby_web_server.Controllers
{
    public abstract class ShopController
    {
        private static readonly ShopItemService ShopItemService = new ShopItemService();
        private static readonly UserShopService UserShopService = new UserShopService();
        private static readonly CommentService CommentService = new CommentService();

        public static async Task GetAllTheShopItems(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
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

                await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                               .ConfigureAwait(false);
            }
        }


        public static async Task ViewOneShopItem(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                if (context.DynamicPath is { Length: > 0 })
                {
                    ShopItem shopItem = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath[0]);
                    if(shopItem == null)  throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

                    {
                        UserShop userShop = await UserShopService.GetProductByItemId(shopItem.Id);
                        userShop.TotalViews +=1;
                        await UserShopService.ProductUpdateByItemId(userShop.Id, userShop);
                        var response = new
                        {
                            status = "Success",
                            body = shopItem
                        };
                        await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                            .ConfigureAwait(false);
                    }
                }
                else
                {
                    throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
                }
            }
            else
            {
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            }
        }

        public static async Task UpdateOneShopItem(HttpContext context)
        {
            var checkMiddleWare = new CheckMiddleWare();

            if (context.Request.HttpMethod == "PUT" || context.Request.HttpMethod == "PATCH")
            {
                Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

                if (!jwt.ContainsKey("jwt"))
                {
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                }

                if (!NullEmptyChecker.HasNullEmptyValues(jwt["jwt"]))
                {
                    string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding).ReadToEndAsync().ConfigureAwait(false);
                    Dictionary<string, object> validateResult = await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

                    ShopItem shopItem  = (ShopItem)validateResult["data"];

                    if (!NullEmptyChecker.HasNullEmptyValues(shopItem))
                    {
                        ShopItem shopItemByReqId = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath?[1]);
                        if (shopItemByReqId == null) throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

                        shopItemByReqId.Name = shopItem.Name;
                        shopItemByReqId.Description = shopItem.Description;
                        shopItemByReqId.Price = shopItem.Price;

                        bool isUpdate = await ShopItemService.UpdateShopItemAsync(shopItemByReqId.Id, shopItemByReqId);
                        if (isUpdate)
                        {
                            var response = new
                            {
                                status = "Success",
                                message = "ShopItem Updated successfully"
                            };

                            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                                .ConfigureAwait(false);
                        }
                        else
                        {
                            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
                        }
                    }
                    else
                    {
                        throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
                    }
                }
                else
                {
                    throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }.ToJson());
                }
            }
            else
            {
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            }
        }

        public static async Task UploadOneShopItem(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                var checkMiddleWare = new CheckMiddleWare();

                Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

                if (!jwt.ContainsKey("jwt"))
                {
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                }

                if (!NullEmptyChecker.HasNullEmptyValues(jwt["jwt"]))
                {
                    string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding).ReadToEndAsync().ConfigureAwait(false);
                    Dictionary<string, object> validateResult = await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

                    ShopItem shopItem  = (ShopItem)validateResult["data"];

                    if (!NullEmptyChecker.HasNullEmptyValues(shopItem))
                    {
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
                    else
                    {
                        throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
                    }
                }
                else
                {
                    throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }.ToJson());
                }
            }
            else
            {
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            }
        }

        public static async Task OneShopItemComment(HttpContext context)
        {
            var checkMiddleWare = new CheckMiddleWare();
            var request = context.Request;
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context);

            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            var shopId = new ObjectId(context.DynamicPath[0]);
            #pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (context.Request.HttpMethod == "POST")
            {
                if (jwt.TryGetValue("jwt", out var value))
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
                        if(shop == null) throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                        {
                            User user = (User)value;

                            Comment comment = new Comment();
                            if (commentReq?.UserComment != null) comment.UserComment = commentReq?.UserComment;
                            comment.User = user.Id;
                            comment.ShopItem = shop.Id;
                            if (commentReq != null) comment.rate = commentReq.rate;

                            await CommentService.CreateComment(comment);
                        }

                        var response = new
                        {
                            status = "Success",
                            message = "Comment added successfully"
                        };

                        await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                            .ConfigureAwait(false);
                    }
                    
                }
                else
                {
                    throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }.ToJson());
                }
            }
            else if (context.Request.HttpMethod == "GET")
            {
                List<Comment> comment = CommentService.GetAllCommentsByShopItemName(shopId) ?? throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
 
                if(!comment.IsNullOrEmpty()) {
                    var response = new
                    {
                        status = "Success",
                        body = comment
                    };

                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                        .ConfigureAwait(false);
                }
                else
                {
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found" }.ToJson());
                }
            }
            else
            {
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            }
        }
    }
}
