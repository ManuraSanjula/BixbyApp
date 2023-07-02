using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using BixbyShop_LK.Models.Item.Services;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;
using System.Net;

namespace Bixby_web_server.Controllers
{
    public class ShopController
    {
        private static ShopItemService ShopItemService = new ShopItemService();

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
                if (context.DynamicPath.Length > 0)
                {
                    ShopItem shopItem = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath[0]);
                    if (shopItem != null)
                    {
                        var response = new
                        {
                            status = "Success",
                            body = shopItem
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
                dynamic result = checkMiddleWare.CheckMiddleWareJWT(context, context.DynamicPath[0]);

                if (result.IsOkay && !NullEmptyChecker.HasNullEmptyValues(result))
                {
                    string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding).ReadToEndAsync().ConfigureAwait(false);
                    dynamic validateResult = checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

                    if (validateResult.IsOkay && !NullEmptyChecker.HasNullEmptyValues(validateResult))
                    {
                        ShopItem updateReq = validateResult.shopItemeq;
                        ShopItem shopItem = await ShopItemService.GetShopItemByIdAsync(context.DynamicPath[1]);

                        if (shopItem != null)
                        {
                            shopItem.Name = updateReq.Name;
                            shopItem.Description = updateReq.Description;
                            shopItem.Price = updateReq.Price;

                            if (await ShopItemService.UpdateShopItemAsync(shopItem.Id, shopItem))
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
                            throw new NotFoundException(new { status = "An error occurred.", message = "Not Found" }.ToJson());
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

                dynamic result = checkMiddleWare.CheckMiddleWareJWT(context, context.DynamicPath[0]);

                if (result.IsOkay && !NullEmptyChecker.HasNullEmptyValues(result))
                {
                    string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding).ReadToEndAsync().ConfigureAwait(false);
                    dynamic validateResult = checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

                    if (validateResult.IsOkay && !NullEmptyChecker.HasNullEmptyValues(validateResult))
                    {
                        await ShopItemService.CreateShopItemAsync(validateResult.shopItemeq);

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
    }
}
