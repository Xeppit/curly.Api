using System.Threading;
using System.Threading.Tasks;
using curly.Api.Controllers.V1.Request;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class CompanyDeleteHandler : IRequestHandler<CompanyDeleteRequest, CompanyDeleteResponse>
    {
        CompanyService _companyService;

        public CompanyDeleteHandler(CompanyService companyService)
        {
            _companyService = companyService;
        }
        public async Task<CompanyDeleteResponse> Handle(CompanyDeleteRequest request, CancellationToken cancellationToken)
        {
            var _result = await _companyService.DeleteByIdAsync(request.Id);
            
            return new CompanyDeleteResponse(_result);
        }
    }
}