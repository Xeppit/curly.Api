using curly.Api.Controllers.V1.Responses;
using curly.Api.Models.Database;
using MediatR;

namespace curly.Api.Controllers.V1.Command
{
    public class ProjectUpsertRequest : IRequest<ProjectResponse>
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public Address Site { get; set; }
        public Company Customer { get; set; }
        public Contact Contact { get; set; }
        public string Status { get; set; }
        public string ProjectDirectoryName { get; set; }
    }
}