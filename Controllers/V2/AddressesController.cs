using System.Collections.Generic;
using System.Threading.Tasks;
using curly.Api.Controllers.V1.Request;
using curly.Api.Controllers.V1.Response;
using curly.Api.Models.Database;
using curly.Api.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curly.Api.Controllers.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly AddressService _addressService;
        private IMediator _mediator;

        public AddressesController(AddressService addressService, IMediator mediator)
        {
            _addressService = addressService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var _request = new AddressGetAllRequest();
            var _result = await _mediator.Send(_request);
            return Ok(_result);
        }
            

        [HttpGet("{id:length(24)}", Name = "Getaddress")]
        public async Task<IActionResult> Get(string id)
        {
            var _request = new AddressGetByIdRequest(id);
            var _result = await _mediator.Send(_request);
            return _result != null ? (IActionResult) Ok(_result) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Address>> Create(AddressCreateRequest request)
        {
            var _result = await _mediator.Send(request);
            return CreatedAtRoute("GetAddress", new { id = _result.Id.ToString() }, _result);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(AddressUpdateRequest request)
        {
            var _result = await _mediator.Send(request);
            return _result != null ? (IActionResult) Ok(_result) : NotFound();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var _request = new AddressDeleteRequest(id);
            var _result = await _mediator.Send(_request);
            return _result.DeleteRecords > 0 ? (IActionResult) Ok(_result) : NotFound();
        }
    }
}