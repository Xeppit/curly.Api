using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Controllers.V1.Responses;
using curly.Api.Services;
using MediatR;

namespace curly.Api.Controllers.V1.Handler
{
    public class AddressGetByIdHandler : IRequestHandler<AddressGetByIdRequest, AddressResponse>
    {
        AddressService _addressService;
        IMapper _mapper;

        public AddressGetByIdHandler(AddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }
        public async Task<AddressResponse> Handle(AddressGetByIdRequest request, CancellationToken cancellationToken)
        {
            var _result = await _addressService.GetByIdAsync(request.Id);
            var _mappedResult = _mapper.Map<AddressResponse>(_result);
            return _mappedResult;
        }
    }
}