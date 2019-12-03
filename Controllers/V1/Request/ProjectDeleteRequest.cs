using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class ProjectDeleteRequest : IRequest<ProjectDeleteResponse>
    {
        public string Id { get; }

        public ProjectDeleteRequest(string id)
        {
            Id = id;
        }
    }
}