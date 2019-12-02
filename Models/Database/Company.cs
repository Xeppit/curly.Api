using curly.Api.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace curly.Api.Models.Models.Database
{
    public class Company : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string AddressId { get; set; }
        public string Address { get; set; }

        //public string SearchString => this.Name;
    }
}
