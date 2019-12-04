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
    public class ProjectUpsertHandler : IRequestHandler<ProjectUpsertRequest, ProjectResponse>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectUpsertHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<ProjectResponse> Handle(ProjectUpsertRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Project>(request);
            var _result = await _projectService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<ProjectResponse>(_result);
            return _mappedResult;
        }
    }
}