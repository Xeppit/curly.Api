using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Models.Database;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ProjectCreateHandler : IRequestHandler<ProjectCreateRequest, ProjectCreateResponse>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectCreateHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<ProjectCreateResponse> Handle(ProjectCreateRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Project>(request);
            var _result = await _projectService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<ProjectCreateResponse>(_result);
            return _mappedResult;
        }
    }
}