using Bixby_web_server.Controllers;

namespace BixbyShop_LK
{

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
