using curly.Api.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace curly.Api.Models.Database
{
    public class Project : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public Address Site { get; set; }
        public Company Customer { get; set; }
        public Contact Contact { get; set; }
        public string Status { get; set; }
        public string ProjectDirectoryName { get; set; }

        //public string SearchString => this.FirstName + " " + this.LastName + " " + this.PhoneNumber + " " + this.Email;
    }
}