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
    public class AddressGetAllHandler : IRequestHandler<AddressGetAllRequest, IEnumerable<AddressResponse>>
    {
        AddressService _addressService;
        IMapper _mapper;

        public AddressGetAllHandler(AddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AddressResponse>> Handle(AddressGetAllRequest request, CancellationToken cancellationToken)
        {
            var _result = await _addressService.GetAllAsync();
            var _mappedResult = _mapper.Map<IEnumerable<AddressResponse>>(_result);
            return _mappedResult;
        }
    }
}