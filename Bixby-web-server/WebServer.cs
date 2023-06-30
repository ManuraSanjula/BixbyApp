using System.Net;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using BCryptNet = BCrypt.Net.BCrypt;

namespace BixbyShop_LK
{
    public class WebServer
    {
        public static UserService UserService = new UserService();

        private readonly int port;
        private readonly HttpListener listener;
        private readonly Dictionary<string, Func<HttpContext, Task>> routeHandlers;
        private readonly SemaphoreSlim semaphore;

        public WebServer(int port)
        {
            this.port = port;
            listener = new HttpListener();
            routeHandlers = new Dictionary<string, Func<HttpContext, Task>>();
            semaphore = new SemaphoreSlim(Environment.ProcessorCount * 2);
            ConfigureRoutes();
        }

        public void Start()
        {
            listener.Prefixes.Add($"http://localhost:{port}/");
            listener.Start();
            Console.WriteLine($"Server started on port {port}");

            Task.Run(() => EventLoop());
        }

        public void Stop()
        {
            listener.Stop();
            listener.Close();
            Console.WriteLine("Server stopped");
        }

        private async Task EventLoop()
        {
            while (true)
            {
                var context = await listener.GetContextAsync().ConfigureAwait(false);
                await semaphore.WaitAsync().ConfigureAwait(false);

                // Handle request in a separate task from the thread pool
                ThreadPool.QueueUserWorkItem(state => ProcessRequest(context));

                // Delay to prevent overwhelming the thread pool with too many concurrent requests
                await Task.Delay(1).ConfigureAwait(false);
            }
        }

        private void ConfigureRoutes()
        {
            routeHandlers.Add("/user/{email}", GetUser);
            routeHandlers.Add("/addUser", AddUser);
            routeHandlers.Add("/login", Login);
            routeHandlers.Add("/updateUser/{email}", HandleUpdateUserRequest);
            
        }

        private static bool WildcardMatch(string input, string pattern)
        {
            var inputSegments = input.Trim('/').Split('/');
            var patternSegments = pattern.Trim('/').Split('/');

            if (inputSegments.Length != patternSegments.Length)
            {
                return false;
            }

            for (int i = 0; i < inputSegments.Length; i++)
            {
                if (!IsSegmentMatch(inputSegments[i], patternSegments[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsSegmentMatch(string inputSegment, string patternSegment)
        {
            if (patternSegment.StartsWith("{") && patternSegment.EndsWith("}"))
            {
                return true; // Placeholder segment matches any input segment
            }

            return inputSegment == patternSegment; // Exact match required
        }

        public String param(HttpListenerContext context, String value)
        {
            var request = context.Request;

            // Get the path from the request URL
            var path = request.Url.AbsolutePath;

            // Get the query string from the request URL
            var queryString = request.Url.Query;

            // Parse the query string parameters
            var queryParams = System.Web.HttpUtility.ParseQueryString(queryString);

            // Example: Extract the value of the "hhh" parameter
            String hhhValue = queryParams[value];

            return hhhValue;
        }

        private async Task ProcessRequest(HttpListenerContext context)
        {
            try
            {
                var request = context.Request;
                var response = context.Response;

                Console.WriteLine($"Received {request.HttpMethod} request: {request.Url.AbsolutePath}");

                var httpContext = new HttpContext(request, response);

                var path = request.Url.AbsolutePath;
                var route = routeHandlers.Keys.FirstOrDefault(route => WildcardMatch(path, route));

                if (route != null && routeHandlers.TryGetValue(route, out var handler))
                {
                    try
                    {
                        httpContext.ExtractDynamicPath(route);
                        // Call the route handler with the extracted dynamic route name
                        await handler(httpContext).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("BadRequest"))
                        {
                            var res = new
                            {
                                message = ex.Message,
                            };
                            await httpContext.WriteResponse(res.ToJson(), "application/json", HttpStatusCode.BadRequest)
                                .ConfigureAwait(false);
                            return;
                        }
                        else if (ex.Message.Contains("InternalServerError"))
                        {
                            var res = new
                            {
                                message = ex.Message,
                            };
                            await httpContext
                                .WriteResponse(res.ToJson(), "application/json", HttpStatusCode.InternalServerError)
                                .ConfigureAwait(false);
                            return;
                        }
                        else if (ex.Message.Contains("Unauthorized"))
                        {
                            var res = new
                            {
                                message = ex.Message,
                            };
                            await httpContext
                                .WriteResponse(res.ToJson(), "application/json", HttpStatusCode.Unauthorized)
                                .ConfigureAwait(false);
                            return;
                        }
                        else if (ex.Message.Contains("Method Not Allowed"))
                        {
                            var res = new
                            {
                                message = ex.Message,
                            };
                            await httpContext
                                .WriteResponse(res.ToJson(), "application/json", HttpStatusCode.MethodNotAllowed)
                                .ConfigureAwait(false);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    var NotFound = new
                    {
                        status = "An error occurred.",
                        message = "Route not found",
                    };
                    await httpContext.WriteResponse(NotFound.ToJson(), "application/json", HttpStatusCode.NotFound)
                        .ConfigureAwait(false);
                    return;
                }
            }
            finally
            {
                semaphore.Release();
                context.Response.Close();
            }
        }


        private async Task GetUser(HttpContext context)
        {
            var message = "Welcome to the home page!";
            await context.WriteResponse(message, "text/plain").ConfigureAwait(false);
        }

        private async Task AddUser(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                var request = context.Request;
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    CheckMiddleWare? checkMiddleWare = new CheckMiddleWare();
                    string json = await reader.ReadToEndAsync().ConfigureAwait(false);

                    checkMiddleWare = checkMiddleWare.CheckUserReq<UserReqAndRes>(json);

                    if (NullEmptyChecker.HasNullEmptyValues(checkMiddleWare))
                    {
                        UserReqAndRes? user = checkMiddleWare.UserReqAndRes;

                        string? res = UserService.CreateNewAccount(user.Email, user.Password, user.FirstName,
                            user.LastName, user.Address);

                        if (res == null)
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

        private async Task Login(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                var request = context.Request;
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    CheckMiddleWare? checkMiddleWare = new CheckMiddleWare();
                    string json = await reader.ReadToEndAsync().ConfigureAwait(false);

                    checkMiddleWare = checkMiddleWare.CheckUserReq<UserLoginReq>(json);
                    if (!NullEmptyChecker.HasNullEmptyValues(checkMiddleWare))
                    {
                        string? token = UserService.Login(checkMiddleWare.UserLoginReq.email,
                            checkMiddleWare.UserLoginReq.secret);
                        var response = new
                        {
                            status = "Success",
                            message = "User logged in successfully",
                            token = token,
                        };

                        await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK)
                            .ConfigureAwait(false);
                        return;
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
        private async Task HandleUpdateUserRequest(HttpContext context)
        {
            var request = context.Request;
            CheckMiddleWare checkMiddleWare = new CheckMiddleWare();
            if (context.Request.HttpMethod == "PUT" || context.Request.HttpMethod == "PATCH")
            {
                if (checkMiddleWare.CheckMiddleWareJWT(context).IsOkay)
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
                                    validateResult.UserReqAndRes.newPassword = BCryptNet.HashPassword(validateResult.UserReqAndRes.newPassword);
                                    validateResult.UserReqAndRes.confirmNewPassword = BCryptNet.HashPassword(validateResult.UserReqAndRes.confirmNewPassword);

                                    if (string.Equals(validateResult.UserReqAndRes.newPassword,
                                            validateResult.UserReqAndRes.confirmNewPassword))
                                    {
                                        validateResult.User.Password = validateResult.UserReqAndRes.newPassword;
                                        
                                        IEmailService emailService = new EmailServiceHelper();
                                        EmailService._emailServiceHelper = emailService;
                                        EmailService.SendEmail(validateResult.User.Email, "Successfully Reset The Password of Your Account 🙂🙂", 2);
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
                                    status = "success",
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
    }
}