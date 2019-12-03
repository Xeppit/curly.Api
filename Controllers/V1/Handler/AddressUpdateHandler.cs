using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Request;
using curly.Api.Models.Database;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class AddressUpdateHandler : IRequestHandler<AddressUpdateRequest, AddressUpdateResponse>
    {
        AddressService _addressService;
        IMapper _mapper;

        public AddressUpdateHandler(AddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }
        public async Task<AddressUpdateResponse> Handle(AddressUpdateRequest request, CancellationToken cancellationToken)
        {
            var _newEntity = _mapper.Map<Address>(request);
            var _result = await _addressService.InsertOrUpdateAsync(_newEntity);
            var _mappedResult = _mapper.Map<AddressUpdateResponse>(_result);
            return _mappedResult;
        }
    }
}