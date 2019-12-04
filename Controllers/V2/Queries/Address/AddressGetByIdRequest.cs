using curly.Api.Controllers.V2.Responses.Address;
using MediatR;

namespace curly.Api.Controllers.V2.Queries.Address
{
    public class AddressGetByIdRequest : IRequest<AddressResponse>
    {
        public string Id { get; }

        public AddressGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}