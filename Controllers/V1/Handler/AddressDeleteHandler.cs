using System.Threading;
using System.Threading.Tasks;
using curly.Api.Controllers.V1.Request;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class AddressDeleteHandler : IRequestHandler<AddressDeleteRequest, AddressDeleteResponse>
    {
        AddressService _addressService;

        public AddressDeleteHandler(AddressService addressService)
        {
            _addressService = addressService;
        }
        public async Task<AddressDeleteResponse> Handle(AddressDeleteRequest request, CancellationToken cancellationToken)
        {
            var _result = await _addressService.DeleteByIdAsync(request.Id);
            
            return new AddressDeleteResponse(_result);
        }
    }
}