using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class CompanyGetByIdHandler : IRequestHandler<CompanyGetByIdRequest, CompanyGetByIdResponse>
    {
        CompanyService _companyService;
        IMapper _mapper;

        public CompanyGetByIdHandler(CompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        public async Task<CompanyGetByIdResponse> Handle(CompanyGetByIdRequest request, CancellationToken cancellationToken)
        {
            var _result = await _companyService.GetByIdAsync(request.Id);
            var _mappedResult = _mapper.Map<CompanyGetByIdResponse>(_result);
            return _mappedResult;
        }
    }
}