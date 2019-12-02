using curly.Api.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace curly.Api.Models.Database
{
    public class Address : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }

        //public string ConcatenatedAddressString =>
        //    this.Name
        //    + ", " + this.Line1
        //    + ", " + this.Line2
        //    + ", " + this.Line3
        //    + ", " + this.Postcode;
    }
}
