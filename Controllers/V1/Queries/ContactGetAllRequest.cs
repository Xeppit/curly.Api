using System.Collections.Generic;
using curly.Api.Controllers.V1.Responses;
using MediatR;

namespace curly.Api.Controllers.V1.Queries
{
    public class ContactGetAllRequest : IRequest<IEnumerable<ContactResponse>>
    {
        
    }
}