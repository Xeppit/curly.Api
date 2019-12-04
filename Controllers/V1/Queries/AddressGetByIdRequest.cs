using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Queries
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