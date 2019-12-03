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
    public class ProjectGetAllHandler : IRequestHandler<ProjectGetAllRequest, IEnumerable<ProjectGetAllResponse>>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectGetAllHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProjectGetAllResponse>> Handle(ProjectGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _projectService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<ProjectGetAllResponse>>(_result);
            return _mappedResult;
        }
    }
}