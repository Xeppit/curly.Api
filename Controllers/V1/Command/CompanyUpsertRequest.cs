using curly.Api.Controllers.V1.Responses;
using curly.Api.Models.Database;
using MediatR;

namespace curly.Api.Controllers.V1.Command
{
    public class CompanyUpsertRequest : IRequest<CompanyResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}