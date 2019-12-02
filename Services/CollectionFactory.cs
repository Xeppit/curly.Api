using curly.Api.Models.Interfaces;
using MongoDB.Driver;

namespace curly.Api.Services
{
    public class CollectionFactory
    {
        private IMongoDatabase _mongoDatabase;
        public CollectionFactory(IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            _mongoDatabase = client.GetDatabase(databaseSettings.DatabaseName);
        }

        public IMongoCollection<TModel> GetCollection<TModel>(string dbCollectionName)
        {
            return _mongoDatabase.GetCollection<TModel>(dbCollectionName);
        }
    }
}