using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Command
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