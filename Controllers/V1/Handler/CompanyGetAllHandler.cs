using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class CompanyGetAllHandler : IRequestHandler<CompanyGetAllRequest, IEnumerable<CompanyResponse>>
    {
        CompanyService _companyService;
        IMapper _mapper;

        public CompanyGetAllHandler(CompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CompanyResponse>> Handle(CompanyGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _companyService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<CompanyResponse>>(_result);
            return _mappedResult;
        }
    }
}