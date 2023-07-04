using System.Timers;
using Bixby_web_server.Controllers;
using StackExchange.Redis;
using Timer = System.Timers.Timer;

namespace Bixby_web_server
{
    public static class Redis
    {
        static ConfigurationOptions _configuration = new ConfigurationOptions
        {
            EndPoints = { "redis-15956.c212.ap-south-1-1.ec2.cloud.redislabs.com:15956" },
            Password = "yHZJh3rRKvU1HJ7bCB8f886VOyZJV8qw",
            AllowAdmin = true
        };
        public delegate void SetRedis(string key, string value);
        public delegate string GetRedis(string key);

        public static readonly ConnectionMultiplexer RedisServer = ConnectionMultiplexer.Connect(_configuration);
        public static IDatabase Db = RedisServer.GetDatabase();

        public static readonly SetRedis Set = (key, value) => Db.StringSet(key, value);
        public static readonly GetRedis Get = key => Db.StringGet(key);

        public static void ConfigureAdminPassword()
        {
            RedisServer.GetDatabase().Execute("AUTH", "yHZJh3rRKvU1HJ7bCB8f886VOyZJV8qw"); // Authenticate using your admin password
        }
        
        public static void FlushRedisDatabase()
        {
            IDatabase redisDb = RedisServer.GetDatabase();
            redisDb.Execute("FLUSHDB");
        }

    }

    public class Program
    {
        static Timer? _timer;
        static WebServer? _webServer;

        private static void RunEvery15Minutes()
        {
            _timer = new Timer(15 * 60 * 1000); // 15 minutes = 15 * 60 * 1000 milliseconds
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            _timer.Start();

            ExecuteTask();

            Thread.Sleep(Timeout.Infinite);
        }

        static void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            ExecuteTask();
        }

        static void ExecuteTask()
        {
            /*Redis.FlushRedisDatabase();*/
        }

        public static void Main(string[] args)
        {
            _webServer = new WebServer(8080);
            _webServer.Start();

            Thread thread = new Thread(RunEvery15Minutes);
            thread.Start();

            _webServer.UseMiddleware(async (context, next) =>
            {
                /*var request = context.Request;
                var path = request.Url?.AbsolutePath;
                var route = _webServer.routeHandlers.Keys.FirstOrDefault(key => WebServer.WildcardMatch(path, key));

                if (route is "/user/{email}" ||
                    route == "/{email}/products/products-orders" ||
                    route == "/{email}/comment" ||
                    route == "/cart/{email}/view" ||
                    route == "/order/{email}/view" ||
                    route == "/shopItem/{shopId}/view" || 
                    route == "/shopItem/{shopId}/comment")
                {
                    string res = Redis.Get(route);
                    if (string.IsNullOrEmpty(res))
                    {
                        Redis.Set(route, context.ResponseContent);
                        await next();
                    }
                    else
                    {
                        context.ResponseContent = res;
                        await context.WriteResponse(res, "application/json", HttpStatusCode.OK).ConfigureAwait(false);
                    }
                }
                */
               
                await next();
            });

            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            _timer?.Stop();
            thread.Join();
            _webServer.Stop();
        }
    }
}
