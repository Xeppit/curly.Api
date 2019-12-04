using MediatR;

namespace curly.Api.Controllers.V2.Command.Address
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