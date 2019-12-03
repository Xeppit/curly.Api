using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class ContactGetByIdRequest : IRequest<ContactGetByIdResponse>
    {
        public string Id { get; }

        public ContactGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}