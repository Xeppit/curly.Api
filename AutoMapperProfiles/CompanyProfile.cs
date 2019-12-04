using AutoMapper;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CompanyGetAllRequest, Company>();
            CreateMap<Company, CompanyResponse>();
            CreateMap<CompanyResponse, Company>();
            CreateMap<Company, CompanyResponse>();
            CreateMap<CompanyUpsertRequest, Company>();
            CreateMap<Company, CompanyResponse>();
        }
    }
}