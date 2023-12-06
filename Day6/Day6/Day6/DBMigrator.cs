using System;
namespace Day6
{
    public class DBMigrator
    {
        private readonly ILogger _logger;
        public DBMigrator(ILogger logger)
        { 
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}"+ DateTime.Now);
            _logger.LogInfo("Migration started at {0}"+ DateTime.Now);

        }
    }
}
