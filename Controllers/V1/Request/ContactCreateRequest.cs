using curly.Api.Models.Database;
using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class ContactCreateRequest : IRequest<ContactCreateResponse>
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