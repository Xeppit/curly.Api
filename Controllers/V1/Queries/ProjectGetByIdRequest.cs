using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Queries
{
    public class ProjectGetByIdRequest : IRequest<ProjectResponse>
    {
        public string Id { get; }

        public ProjectGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}