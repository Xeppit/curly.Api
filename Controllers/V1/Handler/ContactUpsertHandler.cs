using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using curly.Api.Models.Database;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ContactUpsertHandler : IRequestHandler<ContactUpsertRequest, ContactResponse>
    {
        ContactService _contactService;
        IMapper _mapper;

        public ContactUpsertHandler(ContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<ContactResponse> Handle(ContactUpsertRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Contact>(request);
            var _result = await _contactService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<ContactResponse>(_result);
            return _mappedResult;
        }
    }
}