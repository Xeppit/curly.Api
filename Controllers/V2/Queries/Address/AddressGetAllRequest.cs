using System.Collections.Generic;
using curly.Api.Controllers.V1.Response;
using curly.Api.Controllers.V2.Responses.Address;
using MediatR;

namespace curly.Api.Controllers.V2.Queries.Address
{
    public class AddressGetAllRequest : IRequest<IEnumerable<AddressResponse>>
    {
        
    }
}