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
    public class ProjectGetAllHandler : IRequestHandler<ProjectGetAllRequest, IEnumerable<ProjectResponse>>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectGetAllHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProjectResponse>> Handle(ProjectGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _projectService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<ProjectResponse>>(_result);
            return _mappedResult;
        }
    }
}