using MongoDB.Driver;

namespace webapi.DBLayer
{
    public class MongoDbContext
    {
        private IMongoDatabase _database;

        public MongoDbContext (string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public IMongoCollection<T>GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
