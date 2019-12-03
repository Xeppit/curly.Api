using System.Threading;
using System.Threading.Tasks;
using curly.Api.Controllers.V1.Request;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ProjectDeleteHandler : IRequestHandler<ProjectDeleteRequest, ProjectDeleteResponse>
    {
        ProjectService _projectService;

        public ProjectDeleteHandler(ProjectService projectService)
        {
            _projectService = projectService;
        }
        public async Task<ProjectDeleteResponse> Handle(ProjectDeleteRequest request, CancellationToken cancellationToken)
        {
            var _result = await _projectService.DeleteByIdAsync(request.Id);
            
            return new ProjectDeleteResponse(_result);
        }
    }
}