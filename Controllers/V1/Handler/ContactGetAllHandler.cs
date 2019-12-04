using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ContactGetAllHandler : IRequestHandler<ContactGetAllRequest, IEnumerable<ContactResponse>>
    {
        ContactService _contactService;
        IMapper _mapper;

        public ContactGetAllHandler(ContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ContactResponse>> Handle(ContactGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _contactService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<ContactResponse>>(_result);
            return _mappedResult;
        }
    }
}