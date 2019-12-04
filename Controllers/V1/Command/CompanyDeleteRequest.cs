using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Command
{
    public class CompanyDeleteRequest : IRequest<CompanyDeleteResponse>
    {
        public string Id { get; }

        public CompanyDeleteRequest(string id)
        {
            Id = id;
        }
    }
}