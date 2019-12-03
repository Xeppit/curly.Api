using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class CompanyCreateRequest : IRequest<CompanyCreateResponse>
    {
        public string Name { get; set; }
        public string AddressId { get; set; }
        public string Address { get; set; }
    }
}