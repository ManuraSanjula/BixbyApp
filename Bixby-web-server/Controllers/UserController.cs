using Bixby_web_server.Helpers;
using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using System.Dynamic;
using System.Net;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Bixby_web_server.Controllers
{
    public class UserController
    {
        public static UserService UserService = new UserService();

        public static async Task HandleUpdateUserRequest(HttpContext context)
        {
            var request = context.Request;
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            if (context.Request.HttpMethod == "PUT" || context.Request.HttpMethod == "PATCH")
            {
                dynamic result = checkMiddleWare.CheckMiddleWareJWT(context, context.DynamicPath[0]);
                if (result.IsOkay && !NullEmptyChecker.HasNullEmptyValues(result))
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string json = await reader.ReadToEndAsync().ConfigureAwait(false);

                        CheckMiddleWare? validateResult =
                            checkMiddleWare.CheckUserReq<UserReqAndRes>(json, context.DynamicPath);
                        if (!NullEmptyChecker.HasNullEmptyValues(validateResult))
                        {
                            validateResult.User.FirstName = validateResult.UserReqAndRes.FirstName;
                            validateResult.User.LastName = validateResult.UserReqAndRes.LastName;
                            validateResult.User.Address = validateResult.UserReqAndRes.Address;

                            if (validateResult.UserReqAndRes.UpdateUserPass)
                            {
                                if (BCryptNet.Verify(validateResult.UserReqAndRes.Password, validateResult.User.Password))
                                {
                                    if (string.Equals(validateResult.UserReqAndRes.newPassword, validateResult.UserReqAndRes.confirmNewPassword))
                                    {
                                        String newPassword = BCryptNet.HashPassword(validateResult.UserReqAndRes.newPassword);
                                        if (BCryptNet.Verify(validateResult.UserReqAndRes.newPassword, newPassword))
                                        {
                                            validateResult.User.Password = newPassword;
                                            IEmailService emailService = new EmailServiceHelper();
                                            EmailService._emailServiceHelper = emailService;
                                            EmailService.SendEmail(validateResult.User.Email, "Successfully Reset The Password of Your Account 🙂🙂", 2);
                                        }    
                                    }
                                }
                            }

                            if (validateResult.UserReqAndRes.UpdateUserEmail)
                            {
                                if (validateResult.User.EmailVerify)
                                {
                                    validateResult.User.Email = validateResult.UserReqAndRes.Email;
                                    IEmailService emailService = new EmailServiceHelper();
                                    EmailService._emailServiceHelper = emailService;
                                    EmailService.SendEmail(validateResult.User.Email, "Email Verification Code for Your Account 🙂🙂", 0);
                                }
                            }

                            bool IsAcknowledged = UserService.UpdateUser(validateResult.User.Id, validateResult.User);
                            if (!IsAcknowledged)
                            {
                                var BadRequest = new
                                {
                                    status = "An error occurred.",
                                    message = "BadRequest",
                                };
                                throw new Exception(BadRequest.ToJson());
                            }
                            else
                            {
                                var response = new
                                {
                                    status = "Success",
                                    message = "User updated successfully"
                                };
                                await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                                    .ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            var BadRequest = new
                            {
                                status = "An error occurred.",
                                message = "BadRequest",
                            };
                            throw new Exception(BadRequest.ToJson());
                        }
                    }
                }
                else
                {
                    var Unauthorized = new
                    {
                        status = "An error occurred.",
                        message = "Unauthorized",
                    };
                    throw new Exception(Unauthorized.ToJson());
                }
            }
            else
            {
                var MethodNotAllowed = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(MethodNotAllowed.ToJson());
            }
        }

        public static async Task AddUser(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                var request = context.Request;
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    CheckMiddleWare? checkMiddleWare = new CheckMiddleWare();
                    string json = await reader.ReadToEndAsync().ConfigureAwait(false);

                    checkMiddleWare = checkMiddleWare.CheckUserReq<UserReqAndRes>(json, context.DynamicPath);

                    if (NullEmptyChecker.HasNullEmptyValues(checkMiddleWare))
                    {
                        UserReqAndRes? user = checkMiddleWare.UserReqAndRes;

                        if (!user.Password.Equals(user.confirmNewPassword))
                        {
                            var BadRequest = new
                            {
                                status = "An error occurred.",
                                message = "BadRequest",
                            };
                            throw new Exception(BadRequest.ToJson());
                        }

                        string? res = UserService.CreateNewAccount(user.Email, user.Password, user.FirstName,
                            user.LastName, user.Address);

                        if (string.IsNullOrEmpty(res))
                        {
                            var response = new
                            {
                                status = "An error occurred.",
                                message = "Empty Body",
                            };
                            throw new Exception(response.ToJson());
                        }
                        else
                        {
                            var response = new
                            {
                                status = "Success",
                                message = "User added successfully",
                                token = res
                            };

                            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                                .ConfigureAwait(false);
                            return;
                        }
                    }
                    else
                    {
                        var BadRequest = new
                        {
                            status = "An error occurred.",
                            message = "BadRequest",
                        };
                        throw new Exception(BadRequest.ToJson());
                    }
                }
            }
            else
            {
                var response = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(response.ToJson());
            }
        }

        public static async Task email_verify(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                string email = context.DynamicPath[0];
                string token = context.DynamicPath[1];

                User user = UserService.GetUserByEmail(email);
                if (!user.IsTokenExpired(token))
                {
                    user.EmailVerify = true;
                    user.Tokens[token].valid = false;
                    user.Tokens.Remove(token);
                }
                else
                {
                    user.Tokens.Remove(token);
                    var BadRequest = new
                    {
                        status = "An error occurred.",
                        message = "BadRequest",
                    };
                    throw new Exception(BadRequest.ToJson());
                }

                if (UserService.UpdateUser(user.Id, user))
                {
                    var response = new
                    {
                        status = "Success",
                    };
                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
                }
                else
                {
                    var BadRequest = new
                    {
                        status = "An error occurred.",
                        message = "BadRequest",
                    };
                    throw new Exception(BadRequest.ToJson());
                }
            }
            else
            {
                var response = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(response.ToJson());
            }
        }


        public static async Task GetUser(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
                dynamic jwt = checkMiddleWare.CheckMiddleWareJWT(context, context.DynamicPath[0]);

                if (!NullEmptyChecker.HasNullEmptyValues(jwt) && jwt.IsOkay)
                {
                    dynamic user = new ExpandoObject();
                    user.Email = jwt.User.Email;
                    user.FirstName = jwt.User.FirstName;
                    user.LastName = jwt.User.LastName;
                    user.Address = jwt.User.Address;
                    user.EmailVerify = jwt.User.EmailVerify;

                    var response = new
                    {
                        status = "Success",
                        body = user
                    };
                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
                   
                }
                else
                {
                    var BadRequest = new
                    {
                        status = "An error occurred.",
                        message = "BadRequest",
                    };
                    throw new Exception(BadRequest.ToJson());
                }
            }
            else
            {
                var response = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(response.ToJson());
            }
        }

        public static async Task Login(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                var request = context.Request;
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    dynamic? checkMiddleWare = new CheckMiddleWare();
                    string json = await reader.ReadToEndAsync().ConfigureAwait(false);

                    checkMiddleWare = checkMiddleWare.CheckUserReq<UserLoginReq>(json, context.DynamicPath);
                    if (!NullEmptyChecker.HasNullEmptyValues(checkMiddleWare))
                    {
                        string? token = UserService.Login(checkMiddleWare.UserLoginReq.email,
                            checkMiddleWare.UserLoginReq.secret);
                        if (!string.IsNullOrEmpty(token))
                        {
                            var response = new
                            {
                                status = "Success",
                                message = "User logged in successfully",
                                token,
                            };

                            await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                                .ConfigureAwait(false);
                        }
                        else
                        {
                            var Unauthorized = new
                            {
                                status = "An error occurred.",
                                message = "Unauthorized",
                            };
                            throw new Exception(Unauthorized.ToJson());
                        }
                    }
                    else
                    {
                        var BadRequest = new
                        {
                            status = "An error occurred.",
                            message = "BadRequest",
                        };
                        throw new Exception(BadRequest.ToJson());
                    }
                }
            }
            else
            {
                var response = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(response.ToJson());
            }
        }

        public static async Task ResetPasswordReq(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                User user = UserService.GetUserByEmail(context.DynamicPath[0]);

                IEmailService emailService = new EmailServiceHelper();
                EmailService._emailServiceHelper = emailService;
                EmailService.SendEmail(user.Email, "Forgot Password EmailVerification to Reset Password in your Account 🙂🙂", 1);

                var response = new
                {
                    status = "Success",
                };

                await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
            }
            else
            {
                var response = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(response.ToJson());
            }
        }

        public static async Task reset_password(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                string email = context.DynamicPath[0];
                string token = context.DynamicPath[1];

                User user = UserService.GetUserByEmail(email);

                if (!user.IsTokenExpired(token))
                {
                    string password = context.Request.Headers["password"];
                    string conform_password = context.Request.Headers["conform_password"];

                    if (string.IsNullOrEmpty(password) && string.IsNullOrEmpty(conform_password))
                    {
                        var BadRequest = new
                        {
                            status = "An error occurred.",
                            message = "BadRequest",
                        };
                    }
                    else
                    {
                        if (string.Equals(password, conform_password))
                        {
                            string encryptPass = BCryptNet.HashPassword(password);
                            if(BCryptNet.Verify(password, encryptPass))
                            {
                                user.Password = encryptPass;
                                user.Tokens.Remove(token);

                                if (UserService.UpdateUser(user.Id, user))
                                {
                                    var response = new
                                    {
                                        status = "Success",
                                    };
                                    IEmailService emailService = new EmailServiceHelper();
                                    EmailService._emailServiceHelper = emailService;
                                    EmailService.SendEmail(user.Email, "Successfully Reset The Password of Your Account 🙂🙂", 2);
                                    await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
                                }
                                else
                                {
                                    var BadRequest = new
                                    {
                                        status = "An error occurred.",
                                        message = "BadRequest",
                                    };
                                    throw new Exception(BadRequest.ToJson());
                                }
                            }
                            else
                            {
                                user.Tokens.Remove(token);
                                var BadRequest = new
                                {
                                    status = "An error occurred.",
                                    message = "BadRequest",
                                };
                                throw new Exception(BadRequest.ToJson());
                            }
                        }
                        else
                        {
                            user.Tokens.Remove(token);
                            var BadRequest = new
                            {
                                status = "An error occurred.",
                                message = "BadRequest",
                            };
                            throw new Exception(BadRequest.ToJson());
                        }
                    }
                }
                else
                {
                    user.Tokens.Remove(token);
                    var BadRequest = new
                    {
                        status = "An error occurred.",
                        message = "BadRequest",
                    };
                    throw new Exception(BadRequest.ToJson());
                }
            }
            else
            {
                var response = new
                {
                    status = "An error occurred.",
                    message = "Method Not Allowed",
                };
                throw new Exception(response.ToJson());
            }
        }
    }
}