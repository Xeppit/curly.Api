using AutoMapper;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectGetAllRequest, Project>();
            CreateMap<Project, ProjectResponse>();
            CreateMap<ProjectResponse, Project>();
            CreateMap<Project, ProjectResponse>();
            CreateMap<ProjectUpsertRequest, Project>();
            CreateMap<Project, ProjectResponse>();
        }
    }
}