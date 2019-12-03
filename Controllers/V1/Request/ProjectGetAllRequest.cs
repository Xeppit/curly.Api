using System.Collections.Generic;
using curly.Api.Controllers.V1.Response;
using MediatR;

namespace curly.Api.Controllers.V1.Request
{
    public class ProjectGetAllRequest : IRequest<IEnumerable<ProjectGetAllResponse>>
    {
        
    }
}