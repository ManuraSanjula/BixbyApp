using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Item.Services;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;
using System.Net;

namespace Bixby_web_server.Controllers
{
    public class ShopController
    {
        private static ShopItemService ShopItemService = new ShopItemService();
        private static UserShopService UserShopService = new UserShopService();

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
                        UserShop userShop = await UserShopService.GetProductByItemId(shopItem.Id);  
                        if(userShop != null)
                        {
                            userShop.TotalViews +=1;
                            await UserShopService.ProductUpdateByItemId(userShop.Id, userShop);
                        }
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

                Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJWT(context, context.DynamicPath[0]);

                if (!jwt.ContainsKey("jwt"))
                {
                    throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                }

                if (!NullEmptyChecker.HasNullEmptyValues(jwt["jwt"]))
                {
                    string json = await new StreamReader(context.Request.InputStream, context.Request.ContentEncoding).ReadToEndAsync().ConfigureAwait(false);
                    Dictionary<string, object> validateResult = await checkMiddleWare.CheckUserReq<ShopItemeq>(json, context.DynamicPath);

                    if (!jwt.ContainsKey(context.DynamicPath[0]))
                    {
                        throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
                    }

                    if (!validateResult.ContainsKey(context.DynamicPath[0]))
                    {
                        throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
                    }
                    ShopItem shopItem  = (ShopItem)validateResult[context.DynamicPath[0]];

                    if (!NullEmptyChecker.HasNullEmptyValues(shopItem))
                    {
                        ShopItem alredayExit = await ShopItemService.GetShopItemByNameAsync(shopItem.Name);
                        if(alredayExit != null)
                        {
                            await ShopItemService.CreateShopItemAsync(shopItem);

                            ShopItem savedOne = await ShopItemService.GetShopItemByNameAsync(shopItem.Name);

                            if(savedOne == null)
                            {
                                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
                            }

                            await UserShopService.AddProduct(savedOne.publish.Id, savedOne.Id);

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
