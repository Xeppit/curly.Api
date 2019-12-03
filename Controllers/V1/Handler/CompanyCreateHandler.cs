using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Models.Database;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class CompanyCreateHandler : IRequestHandler<CompanyCreateRequest, CompanyCreateResponse>
    {
        CompanyService _companyService;
        IMapper _mapper;

        public CompanyCreateHandler(CompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        public async Task<CompanyCreateResponse> Handle(CompanyCreateRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Company>(request);
            var _result = await _companyService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<CompanyCreateResponse>(_result);
            return _mappedResult;
        }
    }
}