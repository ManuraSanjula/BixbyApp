using Bixby_web_server.Controllers;
using StackExchange.Redis;

namespace Bixby_web_server;

public class TaskScheduler
{
    private Timer? _timer;

    public void Start()
    {
        // Create a timer that calls the ExecuteTask method every 10 minutes
        _timer = new Timer(ExecuteTask, null, TimeSpan.Zero, TimeSpan.FromMinutes(10));
    }

    public void Stop()
    {
        // Dispose the timer to stop the task execution
        _timer?.Dispose();
    }

    private void ExecuteTask(object? state)
    {
        RedisCache.FlushRedisDatabase();
    }
}

public static class RedisCache
{
    private static readonly IDatabase Database;

    static RedisCache()
    {
        var connectionString =
            "bixbyapp.redis.cache.windows.net:6380,password=CBas2gkhQQWt3LqrhqIaK4E79sa4Xey0WAzCaFHP8uo=,ssl=True,abortConnect=False";
        var connection = ConnectionMultiplexer.Connect(connectionString);
        Database = connection.GetDatabase();
    }

    public static void Set(string? key, string? value)
    {
        Database.StringSet(key, value);
    }

    public static string? Get(string? key)
    {
        return Database.StringGet(key);
    }

    public static bool Remove(string key)
    {
        return Database.KeyDelete(key);
    }

    public static void FlushRedisDatabase()
    {
        // Connection string of your Redis cache
        var connectionString =
            "bixbyapp.redis.cache.windows.net:6380,password=CBas2gkhQQWt3LqrhqIaK4E79sa4Xey0WAzCaFHP8uo=,ssl=True,abortConnect=False";

        // Create a connection to the Redis cache
        var connection = ConnectionMultiplexer.Connect(connectionString);

        // Get the database instance
        var database = connection.GetDatabase();

        // Flush the Redis database
        database.Execute("FLUSHDB");

        // Close the connection
        connection.Close();
    }
}

public abstract class Program
{
    private static WebServer? _webServer;

    public static void Main(string[] args)
    {
        RedisCache.FlushRedisDatabase();
        _webServer = new WebServer(8080);
        _webServer.Start();

        _webServer.UseMiddleware(async (context, next) => { await next(); });

        var taskScheduler = new TaskScheduler();
        taskScheduler.Start();

        Console.WriteLine("Press Enter to stop the task scheduler.");
        Console.ReadLine();

        taskScheduler.Stop();


        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey();

        _webServer.Stop();
    }
}