using curly.Api.Models.Database;
using MongoDB.Driver;

namespace curly.Api.Services
{
    public class ContactService : DataAccessBase<Contact>
    {
        protected override IMongoCollection<Contact> _mongoCollection { get; }

        public ContactService(CollectionFactory collectionFactory)
        {
            _mongoCollection = collectionFactory.GetCollection<Contact>("Contacts");
        }
    }
}