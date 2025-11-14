using Microsoft.Extensions.Options;
using MySqlConnector;
using Villa.Config;
using Villa.Logging;
using Villa.Models;

namespace Villa.Services
{
    public class TestConnectionService : ITestConnectionService
    {
        public readonly ILogging _logger;
        private readonly  string _dbName; 

        public TestConnectionService(ILogging logger, IOptions<DatabaseSettings> test)
        {
            _logger = logger;
            _dbName = test.Value.StaticDatabaseName; ;
        }

        public bool TestConnection(string server, string username, string password, out string errorMessage)
        {
            string connectionString = $"Server={server};Database={_dbName};User ID={username};Password={password};";

            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                errorMessage = null;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                _logger.Log(errorMessage,"error");
                return false;
            }
        }
    }
}
