using curly.Api.Models.Models.Database;
using MongoDB.Driver;

namespace curly.Api.Services
{
    public class PersonService : DataAccessBase<Person>
    {
        protected override IMongoCollection<Person> _mongoCollection { get; }

        public PersonService(CollectionFactory collectionFactory)
        {
            _mongoCollection = collectionFactory.GetCollection<Person>("People");
        }
    }
}