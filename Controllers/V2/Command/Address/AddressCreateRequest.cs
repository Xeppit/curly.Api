using curly.Api.Controllers.V2.Responses.Address;
using MediatR;

namespace curly.Api.Controllers.V2.Command.Address
{
    public class AddressUpsertRequest : IRequest<AddressResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}