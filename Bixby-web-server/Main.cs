using System.Net;
using BixbyShop_LK.Services;
using Newtonsoft.Json;

namespace BixbyShop_LK
{
    public static class TokenAdder
    {
        public static void AddToken(dynamic obj, string token)
        {
            obj.Token = token;
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
            routeHandlers.Add("/updateUser", HandleUpdateUserRequest);
            routeHandlers.Add("/deleteUser", HandleDeleteUserRequest);

            routeHandlers.Add("/addUserPic", HandleFileRequest);

            routeHandlers.Add("/emailVerification", HandleFileRequest);
            routeHandlers.Add("/resetPassword", HandleFileRequest);

            routeHandlers.Add("/emailVerificationReq", HandleFileRequest);
            routeHandlers.Add("/resetPasswordReq", HandleFileRequest);

           
        }

        private void ProcessRequest(HttpListenerContext context)
        {
            try
            {
                var request = context.Request;
                var response = context.Response;

                Console.WriteLine($"Received {request.HttpMethod} request: {request.Url.AbsolutePath}");

                var httpContext = new HttpContext(request, response);

                if (routeHandlers.TryGetValue(request.Url.AbsolutePath, out var handler))
                {
                    try
                    {
                        handler(httpContext).Wait();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        httpContext.WriteResponse("An error occurred.", "text/plain", HttpStatusCode.InternalServerError).Wait();
                    }
                }
                else
                {
                    httpContext.WriteResponse("Route not found.", "text/plain", HttpStatusCode.NotFound).Wait();
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
                        await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.BadRequest).ConfigureAwait(false);
                    }

                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };

                    UserReqAndRes user = JsonConvert.DeserializeObject<UserReqAndRes>(json, settings);

                    if(user == null)
                    {
                        await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.InternalServerError).ConfigureAwait(false);
                    }

                    String res = UserService.CreateNewAccount(user.Email, user.Password, user.FirstName, user.LastName, user.Address);
                    
                    if(res == null)
                    {
                        await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.BadRequest).ConfigureAwait(false);
                    }
                    else
                    {
                        Dictionary<string, string> headers = new Dictionary<string, string>();
                        headers.Add("Token", res);
                        await context.WriteResponse("", "application/json", HttpStatusCode.OK, headers).ConfigureAwait(false);
                    }
                }
            }
            else
            {
                await context.WriteResponse("Method not allowed.", "text/plain", HttpStatusCode.MethodNotAllowed).ConfigureAwait(false);
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
                        await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.BadRequest).ConfigureAwait(false);
                    }

                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };

                    UserLoginReq user = JsonConvert.DeserializeObject<UserLoginReq>(json, settings);
                    if (user == null)
                    {
                        await context.WriteResponse("Opps !!! .", "text/plain", HttpStatusCode.InternalServerError).ConfigureAwait(false);
                    }

                    String token = UserService.Login(user.email, user.secret);
                    Dictionary<string, string> headers = new Dictionary<string, string>();
                    headers.Add("Token", token);

                    await context.WriteResponse("","application/json", HttpStatusCode.OK, headers).ConfigureAwait(false);
                }
            }
            else
            {
                await context.WriteResponse("Method not allowed.", "text/plain", HttpStatusCode.MethodNotAllowed).ConfigureAwait(false);
            }

        }

        private async Task HandleFileRequest(HttpContext context)
        {
            var request = context.Request;

            if (request.HttpMethod == "GET")
            {
                string filePath = "path_to_your_file"; // Specify the path to the file you want to serve
                if (File.Exists(filePath))
                {
                    try
                    {
                        byte[] fileBytes = await File.ReadAllBytesAsync(filePath).ConfigureAwait(false);
                        context.Response.ContentType = "application/octet-stream";
                        context.Response.ContentLength64 = fileBytes.Length;
                        await context.Response.OutputStream.WriteAsync(fileBytes, 0, fileBytes.Length).ConfigureAwait(false);
                        context.Response.StatusCode = (int)HttpStatusCode.OK;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error serving file: {ex.Message}");
                        await context.WriteResponse("An error occurred while serving the file.", "text/plain", HttpStatusCode.InternalServerError).ConfigureAwait(false);
                    }
                }
                else
                {
                    await context.WriteResponse("File not found.", "text/plain", HttpStatusCode.NotFound).ConfigureAwait(false);
                }
            }
            else if (request.HttpMethod == "POST")
            {
                
            }
        }

        private async Task HandleUpdateUserRequest(HttpContext context)
        {
            if (context.Request.HttpMethod == "PUT" || context.Request.HttpMethod == "PATCH")
            {
                var request = context.Request;
                 
                await context.WriteResponse("User updated successfully.", "text/plain").ConfigureAwait(false);
            }
            else
            {
                await context.WriteResponse("Method not allowed.", "text/plain", HttpStatusCode.MethodNotAllowed).ConfigureAwait(false);
            }
        }

        private async Task HandleDeleteUserRequest(HttpContext context)
        {
            if (context.Request.HttpMethod == "DELETE")
            {
               
                await context.WriteResponse("User deleted successfully.", "text/plain").ConfigureAwait(false);
            }
            else
            {
                await context.WriteResponse("Method not allowed.", "text/plain", HttpStatusCode.MethodNotAllowed).ConfigureAwait(false);
            }
        }
    }

    public class HttpContext
    {
        public HttpListenerRequest Request { get; }
        public HttpListenerResponse Response { get; }

        public HttpContext(HttpListenerRequest request, HttpListenerResponse response)
        {
            Request = request;
            Response = response;
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
