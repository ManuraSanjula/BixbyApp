using System.Data.SQLite;
using Dapper;

namespace Bixbu_UI.SQL
{
    public class ConfigDb
    {
        private readonly string databaseFilePath;

        public ConfigDb()
        {
            databaseFilePath = GetDatabaseFilePath();
            InitializeDatabase();
        }

        private string GetDatabaseFilePath()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Bixby", "data");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "bixby.db");
            return filePath;
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Config (
                    Email TEXT,
                    Token TEXT,
                    RabbitMQName TEXT,
                    RabbitMQURL TEXT
                );
            ");
            }
        }

        private string GetConnectionString()
        {
            return $"Data Source={databaseFilePath};Version=3;";
        }

        public void InsertConfig(Config config)
        {
            using (var connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Execute(@"
                INSERT INTO Config (Email, Token, RabbitMQName, RabbitMQURL)
                VALUES (@Email, @Token, @RabbitMQName, @RabbitMQURL);
            ", config);
            }
        }

        public Config GetConfig()
        {
            using (var connection = new SQLiteConnection(GetConnectionString()))
            {
                return connection.QueryFirstOrDefault<Config>("SELECT * FROM Config;");
            }
        }
    }
}
