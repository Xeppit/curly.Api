using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressGetAllRequest, Address>();
            CreateMap<Address, AddressGetAllResponse>();
            CreateMap<Address, AddressGetByIdResponse>();
            CreateMap<AddressCreateRequest, Address>();
            CreateMap<Address, AddressCreateResponse>();
        }
    }
}