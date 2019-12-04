using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ProjectGetByIdHandler : IRequestHandler<ProjectGetByIdRequest, ProjectResponse>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectGetByIdHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<ProjectResponse> Handle(ProjectGetByIdRequest request, CancellationToken cancellationToken)
        {
            var _result = await _projectService.GetByIdAsync(request.Id);
            var _mappedResult = _mapper.Map<ProjectResponse>(_result);
            return _mappedResult;
        }
    }
}