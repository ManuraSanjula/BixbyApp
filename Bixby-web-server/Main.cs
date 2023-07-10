using Bixby_web_server.Controllers;
using Microsoft.Extensions.Configuration;

namespace Bixby_web_server;

public abstract class Program
{
    private static WebServer? _webServer;
    public static IConfiguration configuration = new ConfigurationBuilder()
        .AddInMemoryCollection()
        .Build();
    public static void Main(string[] args)
    {
        _webServer = new WebServer(8080);
        _webServer.Start();
        
       

        configuration["ServerPort"] = "8080"; // Set the desired port number

        string portNumber = configuration["ServerPort"];
        Console.WriteLine("Server Port: " + portNumber);
        

        _webServer.UseMiddleware(async (context, next) => { await next(); });

        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey();

        _webServer.Stop();
    }
}