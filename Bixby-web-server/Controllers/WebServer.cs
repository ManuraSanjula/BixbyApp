using System.Net;
using Bixby_web_server.Helpers;
using BixbyShop_LK.Services;
using MongoDB.Bson;

namespace Bixby_web_server.Controllers
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
            routeHandlers.Add("/user/{email}", UserController.GetUser);
            routeHandlers.Add("/addUser", UserController.AddUser);
            routeHandlers.Add("/login", UserController.Login);
            routeHandlers.Add("/updateUser/{email}", UserController.HandleUpdateUserRequest);

            routeHandlers.Add("/reset-password-req/{email}", UserController.ResetPasswordReq);

            routeHandlers.Add("/reset-password/{email}/{token}", UserController.reset_password);
            routeHandlers.Add("/email-verify/{email}/{token}", UserController.email_verify);
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

        public string param(HttpListenerContext context, string value)
        {
            var request = context.Request;

            // Get the path from the request URL
            var path = request.Url.AbsolutePath;

            // Get the query string from the request URL
            var queryString = request.Url.Query;

            // Parse the query string parameters
            var queryParams = System.Web.HttpUtility.ParseQueryString(queryString);

            // Example: Extract the value of the "hhh" parameter
            string hhhValue = queryParams[value];

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
                            var res = new
                            {
                                message = ex.ToString(),
                            };
                            await httpContext.WriteResponse(res.ToJson(), "application/json", HttpStatusCode.BadRequest)
                                .ConfigureAwait(false);
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

        
    }
}