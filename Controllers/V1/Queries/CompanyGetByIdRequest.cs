using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Queries
{
    public class CompanyGetByIdRequest : IRequest<CompanyResponse>
    {
        public string Id { get; }

        public CompanyGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}