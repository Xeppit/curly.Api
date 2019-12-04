using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V2.Handler.Address
{
    public class AddressGetByIdHandler : IRequestHandler<AddressGetByIdRequest, AddressGetByIdResponse>
    {
        AddressService _addressService;
        IMapper _mapper;

        public AddressGetByIdHandler(AddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }
        public async Task<AddressGetByIdResponse> Handle(AddressGetByIdRequest request, CancellationToken cancellationToken)
        {
            var _result = await _addressService.GetByIdAsync(request.Id);
            var _mappedResult = _mapper.Map<AddressGetByIdResponse>(_result);
            return _mappedResult;
        }
    }
}