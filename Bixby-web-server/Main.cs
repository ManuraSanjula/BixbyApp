using Bixby_web_server.Controllers;

namespace Bixby_web_server;

public abstract class Program
{
    private static WebServer? _webServer;

    public static void Main(string[] args)
    {
        _webServer = new WebServer(8080);
        _webServer.Start();

        _webServer.UseMiddleware(async (context, next) => { await next(); });

        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey();

        _webServer.Stop();
    }
}