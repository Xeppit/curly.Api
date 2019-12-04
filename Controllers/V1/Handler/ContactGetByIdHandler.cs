using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ContactGetByIdHandler : IRequestHandler<ContactGetByIdRequest, ContactResponse>
    {
        ContactService _contactService;
        IMapper _mapper;

        public ContactGetByIdHandler(ContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<ContactResponse> Handle(ContactGetByIdRequest request, CancellationToken cancellationToken)
        {
            var _result = await _contactService.GetByIdAsync(request.Id);
            var _mappedResult = _mapper.Map<ContactResponse>(_result);
            return _mappedResult;
        }
    }
}