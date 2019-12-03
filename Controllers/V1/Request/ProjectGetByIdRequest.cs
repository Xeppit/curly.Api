using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class ProjectGetByIdRequest : IRequest<ProjectGetByIdResponse>
    {
        public string Id { get; }

        public ProjectGetByIdRequest(string id)
        {
            Id = id;
        }
    }
}