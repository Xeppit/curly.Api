using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class CompanyGetByIdRequest : IRequest<CompanyGetByIdResponse>
    {
        public string Id { get; }

        public CompanyGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}