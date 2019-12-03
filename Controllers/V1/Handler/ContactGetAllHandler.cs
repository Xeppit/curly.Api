using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ContactGetAllHandler : IRequestHandler<ContactGetAllRequest, IEnumerable<ContactGetAllResponse>>
    {
        ContactService _contactService;
        IMapper _mapper;

        public ContactGetAllHandler(ContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ContactGetAllResponse>> Handle(ContactGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _contactService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<ContactGetAllResponse>>(_result);
            return _mappedResult;
        }
    }
}