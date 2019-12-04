using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Command
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