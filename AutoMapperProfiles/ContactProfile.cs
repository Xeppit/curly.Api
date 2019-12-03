using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactGetAllRequest, Contact>();
            CreateMap<Contact, ContactGetAllResponse>();
            CreateMap<Contact, ContactGetByIdResponse>();
            CreateMap<ContactCreateRequest, Contact>();
            CreateMap<Contact, ContactCreateResponse>();
        }
    }
}