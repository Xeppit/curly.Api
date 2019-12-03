using curly.Api.Models.Database;
using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class CompanyCreateRequest : IRequest<CompanyCreateResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}