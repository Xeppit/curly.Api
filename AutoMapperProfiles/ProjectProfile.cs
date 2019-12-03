using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectGetAllRequest, Project>();
            CreateMap<Project, ProjectGetAllResponse>();
            CreateMap<Project, ProjectGetByIdResponse>();
            CreateMap<ProjectCreateRequest, Project>();
            CreateMap<Project, ProjectCreateResponse>();
        }
    }
}