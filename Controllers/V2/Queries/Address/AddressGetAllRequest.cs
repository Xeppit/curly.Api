using System.Collections.Generic;
using curly.Api.Controllers.V1.Response;
using MediatR;

namespace curly.Api.Controllers.V2.Queries.Address
{
    public class AddressGetAllRequest : IRequest<IEnumerable<AddressGetAllResponse>>
    {
        
    }
}