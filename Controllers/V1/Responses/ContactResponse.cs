using curly.Api.Models.Database;

namespace curly.Api.Controllers.V1.Responses
{
    public class ContactResponse
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