using MediatR;

namespace curly.Api.Controllers.V2.Queries.Address
{
    public class AddressGetByIdRequest : IRequest<AddressGetByIdResponse>
    {
        public string Id { get; }

        public AddressGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}