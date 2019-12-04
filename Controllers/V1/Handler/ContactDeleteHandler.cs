using System.Threading;
using System.Threading.Tasks;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class ContactDeleteHandler : IRequestHandler<ContactDeleteRequest, ContactDeleteResponse>
    {
        ContactService _contactService;

        public ContactDeleteHandler(ContactService contactService)
        {
            _contactService = contactService;
        }
        public async Task<ContactDeleteResponse> Handle(ContactDeleteRequest request, CancellationToken cancellationToken)
        {
            var _result = await _contactService.DeleteByIdAsync(request.Id);
            
            return new ContactDeleteResponse(_result);
        }
    }
}