using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CompanyGetAllRequest, Company>();
            CreateMap<Company, CompanyGetAllResponse>();
            CreateMap<Company, CompanyGetByIdResponse>();
            CreateMap<CompanyCreateRequest, Company>();
            CreateMap<Company, CompanyCreateResponse>();
        }
    }
}