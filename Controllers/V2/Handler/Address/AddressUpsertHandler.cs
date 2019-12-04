using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V2.Command.Address;
using curly.Api.Controllers.V2.Responses.Address;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V2.Handler.Address
{
    public class AddressUpsertHandler : IRequestHandler<AddressUpsertRequest, AddressResponse>
    {
        AddressService _addressService;
        IMapper _mapper;

        public AddressUpsertHandler(AddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }
        public async Task<AddressResponse> Handle(AddressUpsertRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Address>(request);
            var _result = await _addressService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<AddressUpsertResponse>(_result);
            return _mappedResult;
        }
    }
}