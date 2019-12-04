using AutoMapper;
using curly.Api.Controllers.V2.Command.Address;
using curly.Api.Controllers.V2.Queries.Address;
using curly.Api.Controllers.V2.Responses.Address;
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