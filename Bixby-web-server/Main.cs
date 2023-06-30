using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using Newtonsoft.Json;
using SendGrid;

namespace BixbyShop_LK
{
    public static class TokenAdder
    {
        public static void AddToken(dynamic obj, string token)
        {
            obj.Token = token;
        }
    }

    public static class HttpResponseExtensions
    {
        public static async Task WriteJsonAsync(this HttpListenerResponse response, object obj)
        {
            response.ContentType = "application/json";
            var json = JsonConvert.SerializeObject(obj);
            var buffer = Encoding.UTF8.GetBytes(json);
            response.ContentLength64 = buffer.Length;
            await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
        }

        public static async Task WriteAsync(this HttpListenerResponse response, string content)
        {
            var buffer = Encoding.UTF8.GetBytes(content);
            response.ContentLength64 = buffer.Length;
            await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
        }
    }

    public class UserLoginReq
    {
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("password")]
        public string secret { get; set; }
    }

    public class UserReqAndRes
    {
        [JsonProperty("firstName")]
        public String FirstName { get; set; }

        [JsonProperty("lastName")]
        public String LastName { get; set; }

        [JsonProperty("email")]
        public String Email { get; set; }

        [JsonProperty("address")]
        public String Address { get; set; }

        [JsonProperty("password")]
        public String Password { get; set; }
    }

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
            routeHandlers.Add("/", HandleHomeRequest);

            routeHandlers.Add("/addUser", AddUser); // ==
            routeHandlers.Add("/login", Login); // ==
            routeHandlers.Add("/updateUser/{email}", HandleUpdateUserRequest);
            routeHandlers.Add("/addUserPic", HandleFileRequest);

            routeHandlers.Add("/emailVerification", HandleFileRequest);
            routeHandlers.Add("/resetPassword", HandleFileRequest);

            routeHandlers.Add("/emailVerificationReq", HandleFileRequest);
            routeHandlers.Add("/resetPasswordReq", HandleFileRequest);

           
        }

        private static bool WildcardMatch(string input, string pattern)
        {
            return Regex.IsMatch(input, $"^{Regex.Escape(pattern).Replace("\\*", ".*")}$");
        }

        private static string ExtractDynamicRouteName(string input, string pattern)
        {
            var regexPattern = $"^{Regex.Escape(pattern).Replace("\\*", "(.*?)")}$";
            var match = Regex.Match(input, regexPattern);
            return match.Groups[1].Value;
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

                // Extract the dynamic route name from the URL
                var path = request.Url.AbsolutePath;
                var route = routeHandlers.Keys.FirstOrDefault(route => WildcardMatch(path, route));
                var dynamicRouteName = ExtractDynamicRouteName(path, route);
                var httpContext = new HttpContext(request, response, dynamicRouteName);

                if (route != null && routeHandlers.TryGetValue(route, out var handler))
                {
                    try
                    {
                        // Call the route handler with the extracted dynamic route name
                        await handler(httpContext).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        await httpContext.WriteResponse("An error occurred.", "text/plain", HttpStatusCode.InternalServerError).ConfigureAwait(false);
                    }
                }
                else
                {
                    await httpContext.WriteResponse("Route not found.", "text/plain", HttpStatusCode.NotFound).ConfigureAwait(false);
                }
            }
            finally
            {
                semaphore.Release();
                context.Response.Close();
            }
        }


        private async Task HandleHomeRequest(HttpContext context)
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
                    string json = await reader.ReadToEndAsync().ConfigureAwait(false);
                    if(json == null)
                    {
                        HandleBadRequest(context, "BadRequest");
                    }

                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };

                    UserReqAndRes user = JsonConvert.DeserializeObject<UserReqAndRes>(json, settings);

                    if(user == null)
                    {
                        HandleServerError(context, new Exception("Server Error"));
                    }

                    String res = UserService.CreateNewAccount(user.Email, user.Password, user.FirstName, user.LastName, user.Address);
                    
                    if(res == null)
                    {
                        HandleBadRequest(context, "BadRequest");
                    }
                    else
                    {
                        Dictionary<string, string> headers = new Dictionary<string, string>();
                        headers.Add("Token", res);
                        var response = new
                        {
                            status = "success",
                            message = "User added successfully"
                        };
                        HandleOkay(context, response.ToJson());
                    }
                }
            }
            else
            {
                HandleMethodNotAllowed(context);
            }
        }

        private async Task Login(HttpContext context)
        {
            if (context.Request.HttpMethod == "POST")
            {
                var request = context.Request;
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    string json = await reader.ReadToEndAsync().ConfigureAwait(false);
                    if (json == null)
                    {
                        HandleBadRequest(context, "BadRequest");
                    }

                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };

                    UserLoginReq user = JsonConvert.DeserializeObject<UserLoginReq>(json, settings);
                    if (user == null)
                    {
                        HandleServerError(context, new Exception("Server Error"));
                        await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.InternalServerError).ConfigureAwait(false);
                    }

                    String token = UserService.Login(user.email, user.secret);
                    Dictionary<string, string> headers = new Dictionary<string, string>();
                    headers.Add("Token", token);

                    var response = new
                    {
                        status = "success",
                        message = "User logged in successfully",
                    };
                    HandleOkay(context, response.ToJson());
                }
            }
            else
            {
                HandleMethodNotAllowed(context);
            }

        }

        private async Task HandleFileRequest(HttpContext context)
        {
            if (context.Request.HttpMethod != "POST")
            {
                await HandleMethodNotAllowed(context);
                return;
            }

            try
            {
                var request = context.Request;
                if (!request.HasEntityBody)
                {
                    await HandleBadRequest(context, "No file found in the request");
                    return;
                }

                var contentType = request.Headers["Content-Type"];
                if (string.IsNullOrEmpty(contentType) || !contentType.StartsWith("multipart/form-data"))
                {
                    await HandleBadRequest(context, "Invalid content type for file upload");
                    return;
                }

                var tempFilePath = Path.GetTempFileName();
                using (var fileStream = File.Create(tempFilePath))
                {
                    request.InputStream.CopyTo(fileStream);
                }

                // Resize the image and save it
                var resizedFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".jpg");
                ResizeImage(tempFilePath, resizedFilePath, 800, 600);

                // Perform further operations on the resized image
                // ...

                File.Delete(tempFilePath);

                HandleOkay(context, "File uploaded and processed successfully");
            }
            catch (Exception ex)
            {
                await HandleServerError(context, ex);
            }
        }


        private async Task HandleUnAuthorized(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            await context.Response.WriteAsync("Unauthorized");
        }

        private async Task HandleOkay(HttpContext context, String json)
        {
            await context.WriteResponse(json, "application/json", HttpStatusCode.OK).ConfigureAwait(false);
        }

        private async Task HandleMethodNotAllowed(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.MethodNotAllowed;
            await context.Response.WriteAsync("Method not allowed");
        }

        private async Task HandleBadRequest(HttpContext context, string message)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            await context.Response.WriteAsync(message);
        }

        private async Task HandleServerError(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync("An error occurred: " + ex.Message);
        }

        private void ResizeImage(string sourceImagePath, string targetImagePath, int maxWidth, int maxHeight)
        {
            using (var image = Image.Load(sourceImagePath))
            {
                image.Mutate(x => x.Resize(new ResizeOptions
                {
                    Size = new Size(maxWidth, maxHeight),
                    Mode = ResizeMode.Max
                }));
                image.Save(targetImagePath);
            }
        }

        private async Task HandleUpdateUserRequest(HttpContext context)
        {
            if (context.Request.HttpMethod == "PUT" || context.Request.HttpMethod == "PATCH")
            {
                var request = context.Request;

                User jwtUser = GetTheUserFromToken(request);

                if(jwtUser != null)
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string json = await reader.ReadToEndAsync().ConfigureAwait(false);
                        if (json == null)
                        {
                            await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.BadRequest).ConfigureAwait(false);
                        }

                        JsonSerializerSettings settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        };

                        UserReqAndRes userReq = JsonConvert.DeserializeObject<UserReqAndRes>(json, settings);

                        if (userReq == null)
                        {
                            HandleServerError(context, new Exception("ServerError"));
                        }

                        if (context.Dynamic.Equals(jwtUser.Email))
                        {
                            User user = UserService.GetUserByEmail(userReq.Email);

                            if (user.Equals(jwtUser))
                            {
                                HandleBadRequest(context, "BadRequest");
                            }
                            user.FirstName = userReq.FirstName;
                            user.LastName = userReq.LastName;
                            user.Address = userReq.Address;

                            bool IsAcknowledged = UserService.UpdateUser(user.Id, user);
                            if (!IsAcknowledged)
                            {
                                HandleBadRequest(context, "BadRequest");
                            }
                            else
                            {
                                var response = new
                                {
                                    status = "success",
                                    message = "User updated successfully"
                                };
                                await context.WriteResponse(response.ToJson(), "application/json", HttpStatusCode.OK).ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            HandleBadRequest(context, "BadRequest");
                        }

                    }
                }
                else
                {
                    await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.Unauthorized).ConfigureAwait(false);
                }
            }
            else
            {
                HandleMethodNotAllowed(context);
            }
        }

        private static User GetTheUserFromToken(HttpListenerRequest request)
        {
            var authorizationHeader = request.Headers["Authorization"];
            if (!string.IsNullOrEmpty(authorizationHeader))
            {
                if (authorizationHeader.StartsWith("Bearer "))
                {
                    var jwtToken = authorizationHeader.Substring("Bearer ".Length);
                    User jwtUser = TokenService.ValidateJwtToken(jwtToken, false, (string token) => { });
                    return jwtUser;
                }
                return null;
            }
            return null;
        }
    }

    public class HttpContext
    {
        public HttpListenerRequest Request { get; }
        public HttpListenerResponse Response { get; }

        public String Dynamic { get; }

        public HttpContext(HttpListenerRequest request, HttpListenerResponse response, String dynamic)
        {
            Request = request;
            Response = response;
            this.Dynamic = dynamic;
        }

        public async Task WriteResponse(string content, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK, Dictionary<string, string> headers = null)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            Response.StatusCode = (int)statusCode;
            Response.ContentType = contentType;
            Response.ContentLength64 = buffer.Length;

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    Response.Headers.Add(header.Key, header.Value);
                }
            }

            await Response.OutputStream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new WebServer(8080);
            server.Start();

            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.Stop();
        }
    }
}
