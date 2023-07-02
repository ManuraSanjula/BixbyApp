using Bixby_web_server.Helpers;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;
using System.Collections.Concurrent;
using System.Net;


namespace Bixby_web_server.Controllers
{
    public class WebServer2
    {
        private readonly int port;
        private readonly HttpListener listener;
        private readonly ConcurrentDictionary<HttpListenerContext, Task> activeRequests;
        private readonly SemaphoreSlim semaphore;

        private readonly Dictionary<string, Func<HttpContext, Task>> routeHandlers;

        public WebServer2(int port)
        {
            this.port = port;
            listener = new HttpListener();
            activeRequests = new ConcurrentDictionary<HttpListenerContext, Task>();
            semaphore = new SemaphoreSlim(200); // Set the default thread pool size to 200
            routeHandlers = new Dictionary<string, Func<HttpContext, Task>>();
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
                var requestTask = ProcessRequestAsync(context);
                activeRequests.TryAdd(context, requestTask);

                // Clean up completed tasks
                await CleanUpCompletedTasks().ConfigureAwait(false);

                // Delay to prevent overwhelming the thread pool with too many concurrent requests
                await Task.Delay(1).ConfigureAwait(false);
            }
        }

        private async Task ProcessRequestAsync(HttpListenerContext context)
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
                        // Handle exceptions and write appropriate responses
                        var statusCode = GetStatusCodeFromException(ex);
                        var res = new
                        {
                            message = ex.ToString(),
                        };
                        await httpContext.WriteResponse(res.ToJson(), "application/json", statusCode)
                            .ConfigureAwait(false);
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
                }
            }
            finally
            {
                semaphore.Release();
                context.Response.Close();
                activeRequests.TryRemove(context, out _);
            }
        }

        private async Task CleanUpCompletedTasks()
        {
            var completedTasks = new List<HttpListenerContext>();

            foreach (var pair in activeRequests)
            {
                if (pair.Value.IsCompleted)
                {
                    completedTasks.Add(pair.Key);
                }
            }

            foreach (var context in completedTasks)
            {
                if (activeRequests.TryRemove(context, out var _))
                {
                    await Task.Yield(); // Ensure the task completes execution before moving on
                }
            }
        }

        private static HttpStatusCode GetStatusCodeFromException(Exception ex)
        {
            // Determine the appropriate status code based on the exception type
            if (ex is BadRequestException)
            {
                return HttpStatusCode.BadRequest;
            }
            else if (ex is UnauthorizedException)
            {
                return HttpStatusCode.Unauthorized;
            }
            else if (ex is MethodNotAllowedException)
            {
                return HttpStatusCode.MethodNotAllowed;
            }
            else if (ex is NotFoundException)
            {
                return HttpStatusCode.NotFound;
            }

            return HttpStatusCode.BadRequest; // Default to BadRequest for other exceptions
        }

        private void ConfigureRoutes()
        {
            routeHandlers.Add("/user/{email}", UserController.GetUser);
            routeHandlers.Add("/addUser", UserController.AddUser);
            routeHandlers.Add("/login", UserController.Login);
            routeHandlers.Add("/updateUser/{email}", UserController.HandleUpdateUserRequest);

            routeHandlers.Add("/reset-password-req/{email}", UserController.ResetPasswordReq);

            routeHandlers.Add("/reset-password/{email}/{token}", UserController.ResetPassword);
            routeHandlers.Add("/email-verify/{email}/{token}", UserController.email_verify);

            routeHandlers.Add("/{email}/add-shop-item", ShopController.UploadOneShopItem);
            routeHandlers.Add("/{email}/update-shop-item/{shopId}", ShopController.UpdateOneShopItem);
            routeHandlers.Add("/shopItem/{shopId}/view", ShopController.ViewOneShopItem);

            routeHandlers.Add("/", ShopController.GetAllTheShopItems);

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
    }
}
