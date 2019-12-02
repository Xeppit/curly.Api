using curly.Api.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace curly.Api.Models.Models.Database
{
    public class Person : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Company Company { get; set; }
        public Address Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //public string SearchString => this.FirstName + " " + this.LastName + " " + this.PhoneNumber + " " + this.Email;
    }
}
