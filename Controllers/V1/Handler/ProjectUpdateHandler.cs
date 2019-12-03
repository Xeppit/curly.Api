using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Models.Database;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ProjectUpdateHandler : IRequestHandler<ProjectUpdateRequest, ProjectUpdateResponse>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectUpdateHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<ProjectUpdateResponse> Handle(ProjectUpdateRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Project>(request);
            var _result = await _projectService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<ProjectUpdateResponse>(_result);
            return _mappedResult;
        }
    }
}