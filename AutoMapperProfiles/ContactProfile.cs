using AutoMapper;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Models.Database;

namespace curly.Api.AutoMapperProfiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactGetAllRequest, Contact>();
            CreateMap<Contact, ContactResponse>();
            CreateMap<ContactResponse, Contact>();
            CreateMap<Contact, ContactResponse>();
            CreateMap<ContactUpsertRequest, Contact>();
            CreateMap<Contact, ContactResponse>();
        }
    }
}