using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using curly.Api.Models.Database;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class CompanyUpsertHandler : IRequestHandler<CompanyUpsertRequest, CompanyResponse>
    {
        CompanyService _companyService;
        IMapper _mapper;

        public CompanyUpsertHandler(CompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        public async Task<CompanyResponse> Handle(CompanyUpsertRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Company>(request);
            var _result = await _companyService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<CompanyResponse>(_result);
            return _mappedResult;
        }
    }
}