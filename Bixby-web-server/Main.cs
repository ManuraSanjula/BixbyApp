using System.Net;

namespace MyWebServer
{
    public class WebServer
    {
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
            routeHandlers.Add("/about", HandleAboutRequest);
            routeHandlers.Add("/file", HandleFileRequest);
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

        private async Task HandleAboutRequest(HttpContext context)
        {
            var message = "This is the about page!";
            await context.WriteResponse(message, "text/plain").ConfigureAwait(false);
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
                // Handle file upload
                // Access the uploaded file using request.InputStream
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

        public async Task WriteResponse(string content, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            Response.StatusCode = (int)statusCode;
            Response.ContentType = contentType;
            Response.ContentLength64 = buffer.Length;
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
