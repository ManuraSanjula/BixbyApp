using System.Data.Entity;
using System.Data.SQLite;

namespace Bixbu_UI.SQL;

public class Config
{
    public string Email { get; set; }
    public string Token { get; set; }
    public string RabbitMQName { get; set; }
    public string RabbitMQURL { get; set; }
}

public class ConfigService
{
    private readonly SQlDBContext _dbContext;

    public ConfigService()
    {
        _dbContext = new SQlDBContext();
    }

    public Config GetConfig()
    {
        return _dbContext.Configurations.FirstOrDefault();
    }

    public void UpdateConfig(Config config)
    {
        var existingConfig = _dbContext.Configurations.FirstOrDefault();
        if (existingConfig != null)
        {
            existingConfig.Email = config.Email;
            existingConfig.Token = config.Token;
            existingConfig.RabbitMQName = config.RabbitMQName;
            existingConfig.RabbitMQURL = config.RabbitMQURL;
            _dbContext.SaveChanges();
        }
    }
}


public class SQlDBContext : DbContext
{
    public SQlDBContext() : base(new SQLiteConnection()
    {
        ConnectionString = new SQLiteConnectionStringBuilder()
        {
            DataSource = GetDatabaseFilePath(),
            ForeignKeys = true
        }.ToString()
    }, true)
    {
        // Ensure the database file and folder exist
        InitializeDatabaseFolder();
    }

    public DbSet<Config> Configurations { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Config>().ToTable("Config");
    }

    private static string GetDatabaseFilePath()
    {
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Bixby", "data");
        Directory.CreateDirectory(folderPath);
        string filePath = Path.Combine(folderPath, "bixby.db");
        return filePath;
    }

    private static void InitializeDatabaseFolder()
    {
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Bixby", "data");
        Directory.CreateDirectory(folderPath);
    }
}



public class SQLService
{
    public static void Save(String email, String token)
    {
        using (var dbContext = new SQlDBContext())
        {
            // Perform database operations here

            // Example: Create a new Config object and save it to the database
            var config = new Config
            {
                Email = email,
                Token = token,
                RabbitMQName = "rabbitmq",
                RabbitMQURL = "rabbitmqurl"
            };

            dbContext.Configurations.Add(config);
            dbContext.SaveChanges();

            // Example: Retrieve the Config object from the database
            var retrievedConfig = dbContext.Configurations.FirstOrDefault();

            if (retrievedConfig != null)
            {
                Console.WriteLine($"Email: {retrievedConfig.Email}");
                Console.WriteLine($"Token: {retrievedConfig.Token}");
                Console.WriteLine($"RabbitMQName: {retrievedConfig.RabbitMQName}");
                Console.WriteLine($"RabbitMQURL: {retrievedConfig.RabbitMQURL}");
            }
        }
    }
}