using Bixby_web_server.Controllers;
using Bixby_web_server.Helpers;

namespace BixbyShop_LK
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var webServer = new WebServer(8080);
            webServer.Start();

            webServer.UseMiddleware(async (context, next) =>
            {
                if (context.Request.Url.AbsolutePath == "/home")
                {
                    // Perform actions specific to the "/home" route
                    await context.WriteResponse("Hello from the home route!", "text/plain");
                }
                else
                {
                    // Continue to the next middleware
                    await next();
                }
            });

            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            webServer.Stop();
        }
    }
}
