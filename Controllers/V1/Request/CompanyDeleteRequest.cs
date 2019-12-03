using MediatR;

namespace curly.Api.Controllers.V1.Request
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