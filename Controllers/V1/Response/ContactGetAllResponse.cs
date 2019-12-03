using curly.Api.Controllers.V1.Request;
using curly.Api.Models.Database;

namespace curly.Api.Controllers.V1.Response
{
    public class ContactGetAllResponse
    {
        public string Id { get; set; }
        public Company Company { get; set; }
        public Address Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}