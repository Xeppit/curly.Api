using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ProjectGetByIdHandler : IRequestHandler<ProjectGetByIdRequest, ProjectGetByIdResponse>
    {
        ProjectService _projectService;
        IMapper _mapper;

        public ProjectGetByIdHandler(ProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }
        public async Task<ProjectGetByIdResponse> Handle(ProjectGetByIdRequest request, CancellationToken cancellationToken)
        {
            var _result = await _projectService.GetByIdAsync(request.Id);
            var _mappedResult = _mapper.Map<ProjectGetByIdResponse>(_result);
            return _mappedResult;
        }
    }
}