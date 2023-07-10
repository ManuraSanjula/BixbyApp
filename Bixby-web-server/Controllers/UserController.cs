using System.Dynamic;
using System.Net;
using System.Net.Sockets;
using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Models.Comments.Services;
using BixbyShop_LK.Models.Item.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Bixby_web_server.Controllers;

public abstract class UserController
{
    private static readonly UserService UserService = new();
    private static readonly ShopItemService ShopItemService = new();
    private static readonly CommentService CommentService = new();
    private static readonly UserShopService UserShopService = new();
    private static readonly ProductPurchasesService ProductPurchasesService = new();

    public static async Task HandleUpdateUserRequest(HttpContext context)
    {
        if (context.Request.HttpMethod != "PUT" && context.Request.HttpMethod != "PATCH")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var request = context.Request;
        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());
        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (!NullEmptyChecker.HasNullEmptyValues(result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        using var reader = new StreamReader(request.InputStream, request.ContentEncoding);
        if (reader == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
        var json = await reader.ReadToEndAsync().ConfigureAwait(false);

        var validateResult = await checkMiddleWare.CheckUserReq<UserReqForUpdate>(json, context.DynamicPath);

        if (validateResult.TryGetValue("UserReqForUpdate", out var value1) &&
            validateResult.TryGetValue("User", out var value))
        {
            var user = (User)value;
            if (user == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            var userReqAndRes = (UserReqForUpdate)value1;
            if (userReqAndRes == null)
                throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

            if (!string.IsNullOrEmpty(userReqAndRes.FirstName)) user.FirstName = userReqAndRes.FirstName;
            if (!string.IsNullOrEmpty(userReqAndRes.LastName)) user.LastName = userReqAndRes.LastName;
            if (!string.IsNullOrEmpty(userReqAndRes.Address)) user.Address = userReqAndRes.Address;

            var response = await UserService.UpdateUserAsync(user.Id, user)
                ? new { status = "Success", message = "User updated successfully" }
                : new { status = "An error occurred.", message = "BadRequest" };
            await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
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
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        using var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
        if (reader == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var checkMiddleWare = new CheckMiddleWare();
        var json = await reader.ReadToEndAsync().ConfigureAwait(false);

        var userCheckResult = await checkMiddleWare.CheckUserReq<UserReqForSignUp>(json, context.DynamicPath);

        var userReqForSignUp = (UserReqForSignUp)userCheckResult["User"];


        if (NullEmptyChecker.HasNullEmptyValues(userReqForSignUp) ||
            !userReqForSignUp.Password.Equals(userReqForSignUp.confirmNewPassword))
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        if (userReqForSignUp == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var token = await UserService.CreateNewAccountAsync(userReqForSignUp.Email, userReqForSignUp.Password,
            userReqForSignUp.FirstName, userReqForSignUp.LastName, userReqForSignUp.Address, context.Url);

        if (string.IsNullOrEmpty(token))
            throw new BadRequestException(new { status = "An error occurred.", message = "Empty Body" }.ToJson());

        var response = new
        {
            status = "Success",
            message = "User added successfully",
            token
        };

        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task email_verify(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = context.DynamicPath?[0];
        var token = context.DynamicPath?[1];

        var user = await UserService.GetUserByEmailAsync(email);
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
            await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
        }
        else
        {
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
        }
    }

    public static async Task GetUser(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]?.Trim());
        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];

        if (!NullEmptyChecker.HasNullEmptyValues(result))
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

        dynamic user = new ExpandoObject();
        if (result.Email != null) user.Email = result.Email;
        user.FirstName = result.FirstName;
        user.LastName = result.LastName;
        user.Address = result.Address;
        user.EmailVerify = result.EmailVerify;
        if (result.Pic != null) user.Pic = result.Pic;

        var response = new
        {
            status = "Success",
            body = user
        };
        context.ResponseContent = response.ToJson();
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task Login(HttpContext context)
    {
        if (context.Request.HttpMethod != "POST")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        using var reader = new StreamReader(context.Request.InputStream, context.Request.ContentEncoding);
        if (reader == null)
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var json = await reader.ReadToEndAsync().ConfigureAwait(false);

        var checkMiddleWare = new CheckMiddleWare();

        var result = await checkMiddleWare.CheckUserReq<UserLoginReq>(json, context.DynamicPath);

        if (NullEmptyChecker.HasNullEmptyValues(result["User"]))
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        var user = (UserLoginReq)result["User"];
        var token = await UserService.LoginAsync(user.email, user.secret, context.Url);

        if (string.IsNullOrEmpty(token))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized" }.ToJson());

        var response = new
        {
            status = "Success",
            message = "User logged in successfully",
            token
        };

        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task ResetPasswordReq(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var user = await UserService.GetUserByEmailAsync(context.DynamicPath[0]);

        if (user == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());


        async void Start()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPHostEntry hostEntry = await Dns.GetHostEntryAsync(hostName);

                IPAddress? localIpAddress = hostEntry.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

                if (localIpAddress != null)
                {
                    string portNumber = Program.configuration["ServerPort"];
                    await EmailService.SendEmail(localIpAddress.ToString() + ":" + portNumber, user.Email, "Forgot Password EmailVerification to Reset Password in your Account 🙂🙂", 1, user);
                }
                else
                {
                    Console.WriteLine("No local IP address found.");
                    await EmailService.SendEmail(context.Url, user.Email, "Forgot Password EmailVerification to Reset Password in your Account 🙂🙂", 1, user);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        Thread thread = new Thread(Start, 4);
        thread.Start();
        
        var response = new
        {
            status = "Success"
        };

        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task ResetPassword(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = context.DynamicPath?[0];
        var token = context.DynamicPath?[1];

        var user = await UserService.GetUserByEmailAsync(email);

        if (user == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());

        if (user.IsTokenExpired(token))
        {
            user.Tokens.Remove(token);
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
        }

        var password = context.Request.Headers["password"];
        var confirmPassword = context.Request.Headers["confirmPassword"];

        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());

        if (!string.Equals(password, confirmPassword))
        {
            user.Tokens.Remove(token);
            throw new BadRequestException(new { status = "An error occurred.", message = "BadRequest" }.ToJson());
        }

        var encryptedPassword = BCryptNet.HashPassword(password);

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
        await EmailService.SendEmail(context.Url, user.Email, "Successfully Reset The Password of Your Account 🙂🙂", 2,
            user);

        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    internal static async Task GettingAllUserProducts(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = context.DynamicPath?[0];
        var user = await UserService.GetUserByEmailAsync(email);

        if (user == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
        var userProducts = await UserShopService.GetProductByUserEmail(user.Email);
        if (userProducts.IsNullOrEmpty())
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());

        var response = new
        {
            status = "Success",
            allTheProducts = userProducts.ConvertAll((item) => new
            {
                _id = item.Id.ToString(),
                item.User,
                Item = item.Item.ToString(),
                TotalSuccessfulOrders = item.TotalSuccessfulOrders.ToString(),
                TotalRefunds = item.TotalRefunds.ToString(),
                TotalViews = item.TotalViews.ToString()
            })
        };
        context.ResponseContent = response.ToJson();
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task GetUserComment(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = context.DynamicPath?[0];
        var user = await UserService.GetUserByEmailAsync(email);

        if (user == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());

        var comments = CommentService.GetAllCommentsByUserName(user.Id);
        if (comments.IsNullOrEmpty())
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
        var response = new
        {
            status = "Success",
            comments
        };
        context.ResponseContent = response.ToJson();
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task RemoveUserProduct(HttpContext context)
    {
        if (context.Request.HttpMethod != "DELETE")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var email = context.DynamicPath?[0];
        var shopId = context.DynamicPath?[1];

        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context, email?.Trim());

        if (!jwt.ContainsKey("jwt"))
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());

        var result = (User)jwt["jwt"];
        var shopItem = await ShopItemService.GetShopItemByIdAsync(new ObjectId(shopId));
        if (shopItem == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFound Exception" }.ToJson());

        var user = await UserService.GetUserByEmailAsync(email);
        if (user == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFound Exception" }.ToJson());

        if (NullEmptyChecker.HasNullEmptyValues(result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        if (!Equals(user, result))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        if (user.Email != null && shopItem.Id != null)
        {
            await UserShopService.DeleteProductByEmailAndShopId(user.Email, shopItem.Id);
            await ShopItemService.DeleteShopItemAsync(shopItem.Id);
        }

        var response = new
        {
            status = "Success"
        };
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task SeePurchase(HttpContext context)
    {
        var request = context.Request;
        var checkMiddleWare = new CheckMiddleWare();
        var jwt = await checkMiddleWare.CheckMiddleWareJwt(context, context.DynamicPath?[0]);

        if (!jwt.ContainsKey("jwt"))
            throw new UnauthorizedException(new { status = "An error occurred.", message = "Unauthorized Exception" }
                .ToJson());

        var result = (User)jwt["jwt"];
        /*if (NullEmptyChecker.HasNullEmptyValues(result))
            throw new NotFoundException(new
                { status = "An error occurred.", message = "Not Found Exception" }.ToJson());*/

        var productPurchases = await ProductPurchasesService.GetProductPurchasesByOwnerIdAsync(result.Email);
        var response = new
        {
            status = "Success",
            productPurchases
        };
        context.ResponseContent = response.ToJson();
        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    internal static async Task EmailVerificationReq(HttpContext context)
    {
        if (context.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());

        var user = await UserService.GetUserByEmailAsync(context.DynamicPath[0]);

        if (user == null)
            throw new NotFoundException(new { status = "An error occurred.", message = "NotFoundException" }.ToJson());
        try
        {
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

            IPAddress? localIpAddress = hostEntry.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            if (localIpAddress != null)
            {
                string portNumber = Program.configuration["ServerPort"];
                await EmailService.SendEmail(localIpAddress.ToString() + ":" + portNumber, user.Email, "Email Verification Code for Your Account 🙂🙂", 0, user);
            }
            else
            {
                Console.WriteLine("No local IP address found.");
                await EmailService.SendEmail(context.Url, user.Email, "Email Verification Code for Your Account 🙂🙂", 0, user);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        var response = new
        {
            status = "Success"
        };

        await context.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }

    public static async Task AddImage(HttpContext arg)
    {
        if (arg.Request.HttpMethod != "GET")
            throw new MethodNotAllowedException(new { status = "An error occurred.", message = "Method Not Allowed" }
                .ToJson());
        var email = arg.DynamicPath?[0];

        var user = await UserService.GetUserByEmailAsync(email);
        var authorizationHeader = arg.Request.Headers["img"];
        if (user != null)
        {
            user.Pic = authorizationHeader;
            await UserService.UpdateUserAsync(user.Id, user);
        }

        var response = new
        {
            status = "Success"
        };
        await arg.WriteResponse(response.ToJson(), "application/json").ConfigureAwait(false);
    }
}