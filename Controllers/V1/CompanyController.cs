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
    public class CompanyController : ControllerBase
    {
        private IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _request = new CompanyGetAllRequest();
            var _result = await _mediator.Send(_request);
            return Ok(_result);
        }
        
        [HttpGet("{id:length(24)}", Name = "Getcompany")]
        public async Task<IActionResult> GetById(string id)
        {
            var _request = new CompanyGetByIdRequest(id);
            var _result = await _mediator.Send(_request);
            return _result != null ? (IActionResult) Ok(_result) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Company>> Upsert(CompanyUpsertRequest request)
        {
            var _result = await _mediator.Send(request);
            return CreatedAtRoute("GetCompany", new { id = _result.Id.ToString() }, _result);
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var _request = new CompanyDeleteRequest(id);
            var _result = await _mediator.Send(_request);
            return _result.DeleteRecords > 0 ? (IActionResult) Ok(_result) : NotFound();
        }
    }
}