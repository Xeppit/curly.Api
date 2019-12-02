using curly.Api.Models.Database;
using MongoDB.Driver;

namespace curly.Api.Services
{
    public class AddressService : DataAccessBase<Address>
    {
        protected override IMongoCollection<Address> _mongoCollection { get; }

        public AddressService(CollectionFactory collectionFactory)
        {
            _mongoCollection = collectionFactory.GetCollection<Address>("Addresses");
        }
    }
}