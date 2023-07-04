using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;
using System.Dynamic;
using System.Net;
using BixbyShop_LK.Models.Comments.Services;
using BCryptNet = BCrypt.Net.BCrypt;
using HttpContext = Bixby_web_server.Helpers.HttpContext;
using BixbyShop_LK.Models.Item.Services;

namespace Bixby_web_server.Controllers
{
    public abstract class UserController
    {
        private static readonly UserService UserService = new UserService();
        private static readonly ShopItemService ShopItemService = new ShopItemService();
        private static readonly CommentService CommentService = new CommentService();
        private static readonly UserShopService UserShopService = new UserShopService();
        private static readonly ProductPurchasesService productPurchasesService = new ProductPurchasesService();

        public static async Task HandleUpdateUserRequest(HttpContext context)
        {
            if (context.Request.HttpMethod != "PUT" && context.Request.HttpMethod != "PATCH")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            var request = context.Request;
            var checkMiddleWare = new CheckMiddleWare();
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);
            
            if (!jwt.ContainsKey("jwt")){
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
            }

            User result = (User)jwt["jwt"];
            if (NullEmptyChecker.HasNullEmptyValues(result))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

            using var reader = new StreamReader(request.InputStream, request.ContentEncoding);
            if(reader == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            string json = await reader.ReadToEndAsync().ConfigureAwait(false);

            Dictionary<string, object> validateResult = await checkMiddleWare.CheckUserReq<UserReqForUpdate>(json, context.DynamicPath);

            if (validateResult.ContainsKey("UserReqForUpdate") && validateResult.TryGetValue("User", out var value))
            {
                {
                    User user = (User)value;
                    if (user == null)
                        throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

                    UserReqForUpdate userReqAndRes = (UserReqForUpdate)validateResult["UserReqForUpdate"];
                    if (userReqAndRes == null)
                        throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

                    if (!string.IsNullOrEmpty(userReqAndRes.FirstName))
                    {
                        user.FirstName = userReqAndRes.FirstName;

                    }
                    if (!string.IsNullOrEmpty(userReqAndRes.LastName))
                    {
                        user.LastName = userReqAndRes.LastName;

                    }
                    if (!string.IsNullOrEmpty(userReqAndRes.Address))
                    {
                        user.Address = userReqAndRes.Address;

                    }

                    var response = await UserService.UpdateUserAsync(user.Id, user)
                        ? new { status = "Success", message = "User updated successfully" }
                        : new { status = "An error occurred.", message = "BadRequest" };

                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
                }
            }
            else
            {
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            }

            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
        }

        public static async Task AddUser(HttpContext context)
        {
            if (context.Request.HttpMethod != "POST")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            using var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
            if(reader == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            var checkMiddleWare = new CheckMiddleWare();
            var json = await reader.ReadToEndAsync().ConfigureAwait(false);

            Dictionary<string, object> userCheckResult = await checkMiddleWare.CheckUserReq<UserReqForSignUp>(json, context.DynamicPath);

            UserReqForSignUp userReqForSignUp = (UserReqForSignUp)userCheckResult["User"];

            if (NullEmptyChecker.HasNullEmptyValues(userReqForSignUp) || !userReqForSignUp.Password.Equals(userReqForSignUp.confirmNewPassword))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            
            if(userReqForSignUp == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            var token = await UserService.CreateNewAccountAsync(userReqForSignUp.Email, userReqForSignUp.Password, userReqForSignUp.FirstName, userReqForSignUp.LastName, userReqForSignUp.Address);

            if (string.IsNullOrEmpty(token))
                throw new BadRequestException(new { status = "An error occurred.", message = "Empty Body" }.ToJson());

            var response = new
            {
                status = "Success",
                message = "User added successfully",
                token
            };

            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task email_verify(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            string? email = context.DynamicPath?[0];
            string? token = context.DynamicPath?[1];

            User? user = await UserService.GetUserByEmailAsync(email);
            if (user != null && !user.IsTokenExpired(token))
            {
                user.EmailVerify = true;
                user.Tokens[token].valid = false;
                user.Tokens.Remove(token);
            }
            else
            {
                user?.Tokens.Remove(token);
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            }

            if (await UserService.UpdateUserAsync(user.Id, user))
            {
                var response = new
                {
                    status = "Success"
                };
                await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
            }
            else
            {
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            }
        }

        public static async Task GetUser(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());

            if (!jwt.ContainsKey("jwt"))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());
            
            User result = (User)jwt["jwt"];

            if (NullEmptyChecker.HasNullEmptyValues(result))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

            dynamic user = new ExpandoObject();
            if (result.Email != null) user.Email = result.Email;
            user.FirstName = result.FirstName;
            user.LastName = result.LastName;
            user.Address = result.Address;
            user.EmailVerify = result.EmailVerify;

            var response = new
            {
                status = "Success",
                body = user
            };
            context.ResponseContent = response.ToJson();
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task Login(HttpContext context)
        {
            if (context.Request.HttpMethod != "POST")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            using var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
            if(reader == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            string json = await reader.ReadToEndAsync().ConfigureAwait(false);

            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();

            Dictionary<string, object> result = await checkMiddleWare.CheckUserReq<UserLoginReq>(json, context.DynamicPath);

            if (NullEmptyChecker.HasNullEmptyValues(result["User"]))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            UserLoginReq user = (UserLoginReq)result["User"];
            string? token = await UserService.LoginAsync(user.email, user.secret);

            if (string.IsNullOrEmpty(token))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }.ToJson());

            var response = new
            {
                status = "Success",
                message = "User logged in successfully",
                token
            };

            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task ResetPasswordReq(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            User user = await UserService.GetUserByEmailAsync(context.DynamicPath[0]);

            if(user == null)
                throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());

            IEmailService emailService = new EmailServiceHelper();
            EmailService._emailServiceHelper = emailService;
            await EmailService.SendEmail(user.Email, "Forgot Password EmailVerification to Reset Password in your Account 🙂🙂", 1);

            var response = new
            {
                status = "Success"
            };

            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task ResetPassword(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            string? email = context.DynamicPath?[0];
            string? token = context.DynamicPath?[1];

            User? user = await UserService.GetUserByEmailAsync(email);

            if(user == null)
            {
                throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
            }

            if (user.IsTokenExpired(token))
            {
                user.Tokens.Remove(token);
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            }

            string? password = context.Request.Headers["password"];
            string? confirmPassword = context.Request.Headers["conform_password"];

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            if (!string.Equals(password, confirmPassword))
            {
                user.Tokens.Remove(token);
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            }

            string encryptedPassword = BCryptNet.HashPassword(password);

            if (!BCryptNet.Verify(password, encryptedPassword))
            {
                user.Tokens.Remove(token);
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
            }

            user.Password = encryptedPassword;
            user.Tokens.Remove(token);

            if (await UserService.UpdateUserAsync(user.Id, user) == false)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            var response = new { status = "Success" };

            IEmailService emailService = new EmailServiceHelper();
            EmailService._emailServiceHelper = emailService;
            await EmailService.SendEmail(user.Email, "Successfully Reset The Password of Your Account 🙂🙂", 2);

            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        internal static async Task GettingAllUserProducts(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            
            string? email = context.DynamicPath?[0];
            User? user = await UserService.GetUserByEmailAsync(email);

            if (user == null)
            {
                throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
            }
            List<UserShop> userProducts = await UserShopService.GetProductByUserEmail(user.Email);
            if(userProducts.IsNullOrEmpty())
            {
                throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
            }
            
            var response = new {
                status = "Success",
                allTheProducts = userProducts
            };
            context.ResponseContent = response.ToJson();
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);

        }

        public static async Task GetUserComment(HttpContext context)
        {
            if (context.Request.HttpMethod != "GET")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());
            
            string? email = context.DynamicPath?[0];
            User? user = await UserService.GetUserByEmailAsync(email);

            if (user == null)
            {
                throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
            }

            List<Comment> comments = CommentService.GetAllCommentsByUserName(user.Id);
            if(comments.IsNullOrEmpty())
            {
                throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
            }
            var response = new {
                status = "Success",
                comments
            };
            context.ResponseContent = response.ToJson();
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task RemoveUserProduct(HttpContext context)
        {
            if (context.Request.HttpMethod != "DELETE")
                throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }.ToJson());

            string? email = context.DynamicPath?[0];
            string? shopId = context.DynamicPath?[0];

            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, email?.Trim());

            if (!jwt.ContainsKey("jwt"))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

            User result = (User)jwt["jwt"];
            ShopItem shopItem = await ShopItemService.GetShopItemByIdAsync(new ObjectId(shopId));
            if (shopItem == null) throw new NotFoundException(new { status = "An error occurred.", message = "NotFound Exception" }.ToJson());

            var user = await UserService.GetUserByEmailAsync(email);
            if (user == null) throw new NotFoundException(new { status = "An error occurred.", message = "NotFound Exception" }.ToJson());

            if (NullEmptyChecker.HasNullEmptyValues(result))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                    .ToJson());

            if (!object.Equals(user, result))
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                    .ToJson());

            if (user.Email != null && shopItem.Id != null)
            {
                await UserShopService.DeleteProductByEmailAndShopId(user.Email, shopItem.Id);
                await ShopItemService.DeleteShopItemAsync(shopItem.Id);
            }

            var response = new {
                status = "Success",
            };
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        public static async Task SeePurchase(HttpContext context)
        {
            var request = context.Request;
            var checkMiddleWare = new CheckMiddleWare();
            Dictionary<string, object> jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

            if (!jwt.ContainsKey("jwt"))
            {
                throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }.ToJson());
            }

            User result = (User)jwt["jwt"];
            if (NullEmptyChecker.HasNullEmptyValues(result))
                throw new NotFoundException(new { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

            List<ProductPurchases> productPurchases = await productPurchasesService.GetProductPurchasesByOwnerIdAsync(result.Email);
            var response = new
            {
                status = "Success",
                productPurchases
            };
            context.ResponseContent = response.ToJson();
            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }
    }
}
