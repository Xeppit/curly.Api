using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Models.Database;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ContactCreateHandler : IRequestHandler<ContactCreateRequest, ContactCreateResponse>
    {
        ContactService _contactService;
        IMapper _mapper;

        public ContactCreateHandler(ContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<ContactCreateResponse> Handle(ContactCreateRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Contact>(request);
            var _result = await _contactService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<ContactCreateResponse>(_result);
            return _mappedResult;
        }
    }
}