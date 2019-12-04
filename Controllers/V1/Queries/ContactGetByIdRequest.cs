using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Queries
{
    public class ContactGetByIdRequest : IRequest<ContactResponse>
    {
        public string Id { get; }

        public ContactGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}