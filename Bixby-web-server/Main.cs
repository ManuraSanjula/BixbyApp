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
                    Console.WriteLine("HI");
                    // Perform actions specific to the "/home" route
                    await next();

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
