using MediatR;

namespace curly.Api.Controllers.V1.Request
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