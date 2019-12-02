using curly.Api.Models.Models.Database;
using MongoDB.Driver;

namespace curly.Api.Services
{
    public class CompanyService : DataAccessBase<Company>
    {
        protected override IMongoCollection<Company> _mongoCollection { get; }

        public CompanyService(CollectionFactory collectionFactory)
        {
            _mongoCollection = collectionFactory.GetCollection<Company>("Companies");
        }
    }
}
