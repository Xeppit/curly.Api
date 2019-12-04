using AutoMapper;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressGetAllRequest, Address>();
            CreateMap<Address, AddressResponse>();
            CreateMap<AddressResponse, Address>();
            CreateMap<Address, AddressResponse>();
            CreateMap<AddressUpsertRequest, Address>();
            CreateMap<Address, AddressResponse>();
        }
    }
}