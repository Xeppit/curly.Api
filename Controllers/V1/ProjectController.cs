using System.Threading.Tasks;
using curly.Api.Controllers.V1.Command;
using curly.Api.Controllers.V1.Queries;
using curly.Api.Models.Database;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace curly.Api.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _request = new ProjectGetAllRequest();
            var _result = await _mediator.Send(_request);
            return Ok(_result);
        }
        
        [HttpGet("{id:length(24)}", Name = "Getproject")]
        public async Task<IActionResult> GetById(string id)
        {
            var _request = new ProjectGetByIdRequest(id);
            var _result = await _mediator.Send(_request);
            return _result != null ? (IActionResult) Ok(_result) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Project>> Upsert(ProjectUpsertRequest request)
        {
            var _result = await _mediator.Send(request);
            return CreatedAtRoute("GetProject", new { id = _result.Id.ToString() }, _result);
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var _request = new ProjectDeleteRequest(id);
            var _result = await _mediator.Send(_request);
            return _result.DeleteRecords > 0 ? (IActionResult) Ok(_result) : NotFound();
        }
    }
}