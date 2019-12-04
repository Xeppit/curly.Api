using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Command
{
    public class ContactDeleteRequest : IRequest<ContactDeleteResponse>
    {
        public string Id { get; }

        public ContactDeleteRequest(string id)
        {
            Id = id;
        }
    }
}