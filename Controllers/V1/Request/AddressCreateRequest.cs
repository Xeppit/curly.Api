using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class AddressCreateRequest : IRequest<AddressCreateResponse>
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}