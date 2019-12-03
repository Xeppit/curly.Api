using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class CompanyGetAllHandler : IRequestHandler<CompanyGetAllRequest, IEnumerable<CompanyGetAllResponse>>
    {
        CompanyService _companyService;
        IMapper _mapper;

        public CompanyGetAllHandler(CompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CompanyGetAllResponse>> Handle(CompanyGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _companyService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<CompanyGetAllResponse>>(_result);
            return _mappedResult;
        }
    }
}