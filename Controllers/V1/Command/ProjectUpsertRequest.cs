using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Command
{
    public class ProjectUpsertRequest : IRequest<ProjectResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}