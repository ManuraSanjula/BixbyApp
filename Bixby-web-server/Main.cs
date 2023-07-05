using Bixby_web_server.Controllers;
using StackExchange.Redis;

namespace Bixby_web_server
{
    public static class RedisCache
    {
        private static readonly ConnectionMultiplexer _connection;
        private static readonly IDatabase _database;

        static RedisCache()
        {
            string connectionString = "bixbyapp.redis.cache.windows.net:6380,password=CBas2gkhQQWt3LqrhqIaK4E79sa4Xey0WAzCaFHP8uo=,ssl=True,abortConnect=False";
            _connection = ConnectionMultiplexer.Connect(connectionString);
            _database = _connection.GetDatabase();
        }

        public static void Set(string key, string value)
        {
            _database.StringSet(key, value);
        }

        public static string Get(string key)
        {
            return _database.StringGet(key);
        }

        public static bool Remove(string key)
        {
            return _database.KeyDelete(key);
        }
    }


    public class Program
    {
        static WebServer? _webServer;
        public static void Main(string[] args)
        {
            _webServer = new WebServer(8080);
            _webServer.Start();

            
            _webServer.UseMiddleware(async (context, next) =>
            {
               
                await next();
            });

            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            _webServer.Stop();
        }
    }
}
