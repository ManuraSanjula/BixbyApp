using System.Collections.Concurrent;
using System.Net;
using Bixby_web_server.Helpers;
using MongoDB.Bson;
using SendGrid.Helpers.Errors.Model;

namespace Bixby_web_server.Controllers;

public static class Startup
{
    public static string ConfirmYourEmail = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot", "AsEmail",
        "ConfirmYourEmail.html");

    public static string ResetPasswordReqEmail = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot",
        "AsEmail", "ResetPasswordReqEmail.html");

    public static string EmailVerificationIsDone =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot", "EmailVerificationIsDone.html");

    public static string PasswordReset =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot", "PasswordReset.html");


    public static string GetFileContent(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

public delegate Task MiddlewareFunc(HttpContext context, Func<Task> next);

public class WebServer
{
    private readonly ConcurrentDictionary<HttpListenerContext, Task> activeRequests;
    private readonly HttpListener listener;
    private readonly List<MiddlewareFunc> middlewares;
    private readonly int port;
    public readonly Dictionary<string, Func<HttpContext, Task>> routeHandlers;

    public WebServer(int port)
    {
        this.port = port;
        listener = new HttpListener();
        activeRequests = new ConcurrentDictionary<HttpListenerContext, Task>();
        routeHandlers = new Dictionary<string, Func<HttpContext, Task>>();
        middlewares = new List<MiddlewareFunc>();
        ConfigureRoutes();
    }

    public void Start()
    {
        listener.Prefixes.Add($"http://localhost:{port}/");
        listener.Start();
        Console.WriteLine($"Server started on port {port}");

        for (var i = 0; i < Environment.ProcessorCount; i++) Task.Run(() => EventLoop());
    }

    public void Stop()
    {
        listener.Stop();
        listener.Close();
        Console.WriteLine("Server stopped");
    }

    public void UseMiddleware(MiddlewareFunc middleware)
    {
        middlewares.Add(middleware);
    }

    private async Task EventLoop()
    {
        while (true)
        {
            var context = await listener.GetContextAsync().ConfigureAwait(false);

            var task = ProcessRequestAsync(context);
            activeRequests.TryAdd(context, task);
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

            foreach (var middleware in middlewares)
            {
                var next = new Func<Task>(() => ProcessRouteAsync(httpContext));
                await middleware(httpContext, next);
            }
        }
        finally
        {
            context.Response.Close();
            activeRequests.TryRemove(context, out _);
        }
    }

    private async Task ProcessRouteAsync(HttpContext httpContext)
    {
        var request = httpContext.Request;
        var path = request.Url?.AbsolutePath;
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
                    message = ex.ToString()
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
                message = "Route not found"
            };
            await httpContext.WriteResponse(NotFound.ToJson(), "application/json", HttpStatusCode.NotFound)
                .ConfigureAwait(false);
        }
    }

    private static HttpStatusCode GetStatusCodeFromException(Exception ex)
    {
        // Determine the appropriate status code based on the exception type
        if (ex is BadRequestException)
            return HttpStatusCode.BadRequest;
        if (ex is UnauthorizedException)
            return HttpStatusCode.Unauthorized;
        if (ex is MethodNotAllowedException)
            return HttpStatusCode.MethodNotAllowed;
        if (ex is NotFoundException) return HttpStatusCode.NotFound;

        return HttpStatusCode.BadRequest; // Default to BadRequest for other exceptions
    }

    private void ConfigureRoutes()
    {
        routeHandlers.Add("/user/{email}", UserController.GetUser); // 👌👍🏻👍🏻
        routeHandlers.Add("/addUser", UserController.AddUser); // 👌👍🏻👍🏻
        routeHandlers.Add("/login", UserController.Login); // 👌👍🏻👍🏻
        routeHandlers.Add("/updateUser/{email}", UserController.HandleUpdateUserRequest);
        routeHandlers.Add("/{email}/products", UserController.GettingAllUserProducts); // 👌👍🏻👍🏻
        routeHandlers.Add("/{email}/products/products-orders", UserController.SeePurchase); // 👍🏻👌👌
        routeHandlers.Add("/{email}/comment", UserController.GetUserComment); // ====
        routeHandlers.Add("/delete/{email}/product/{shopId}", UserController.RemoveUserProduct);

        routeHandlers.Add("/cart/{email}/{shopId}/add", CartController.AddToCart); // 👍🏻👌👌
        routeHandlers.Add("/cart/{email}/view", CartController.SeeAllTheCart); // 👌👍🏻
        routeHandlers.Add("/cart/{email}/check-out", CartController.CheckOutAllItems); // 👍🏻👌

        routeHandlers.Add("/order/{email}/view", OrderController.SeeAllOrders); // 👌👍🏻
        routeHandlers.Add("/order/{email}/{orderId}/refund", OrderController.Refund); // ====
        routeHandlers.Add("/order/{email}/{orderId}/confirm", OrderController.ConfirmTheOrder); // 👌👍🏻

        routeHandlers.Add("/reset-password/{email}/{code}", UserController.ResetPassword); // 👍🏻👍🏻👌👌
        routeHandlers.Add("/email-verify/{email}/{code}", UserController.email_verify); // 👌👍🏻👍🏻

        routeHandlers.Add("/reset-password-req/{email}", UserController.ResetPasswordReq); // 👍🏻👌👌
        routeHandlers.Add("/email-verify-req/{email}", UserController.EmailVerificationReq);

        routeHandlers.Add("/ui/email-verify", StaticWeb.email_verify); // 👌👌👍🏻👍🏻
        routeHandlers.Add("/ui/reset-password", StaticWeb.ResetPassword); // 👍🏻👍🏻👌👌

        routeHandlers.Add("/{email}/add-shop-item", ShopController.UploadOneShopItem); // 👌👍🏻
        routeHandlers.Add("/{email}/update-shop-item/{shopId}", ShopController.UpdateOneShopItem); //===
        routeHandlers.Add("/shopItem/{shopId}/view", ShopController.ViewOneShopItem); // 👍🏻👌
        routeHandlers.Add("/shopItem/{shopId}/comment", ShopController.OneShopItemComment); // ====
        routeHandlers.Add("/shopItem/{shopId}/buy/{email}", ShopController.BuyItem); // 👍🏻👌

        routeHandlers.Add("/home", ShopController.GetAllTheShopItems);
    }

    public static bool WildcardMatch(string input, string pattern)
    {
        var inputSegments = input.Trim('/').Split('/');
        var patternSegments = pattern.Trim('/').Split('/');

        if (inputSegments.Length != patternSegments.Length) return false;

        for (var i = 0; i < inputSegments.Length; i++)
            if (!IsSegmentMatch(inputSegments[i], patternSegments[i]))
                return false;

        return true;
    }

    private static bool IsSegmentMatch(string inputSegment, string patternSegment)
    {
        if (patternSegment.StartsWith("{") && patternSegment.EndsWith("}")) return true;
        return inputSegment == patternSegment;
    }
}