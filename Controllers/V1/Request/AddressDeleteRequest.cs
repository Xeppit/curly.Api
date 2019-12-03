using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class AddressDeleteRequest : IRequest<AddressDeleteResponse>
    {
        public string Id { get; }

        public AddressDeleteRequest(string id)
        {
            Id = id;
        }
    }
}