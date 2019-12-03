using MediatR;

namespace curly.Api.Controllers.V1.Request
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