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
    public class ContactsController : ControllerBase
    {
        private readonly ContactService _contactService;
        private IMediator _mediator;

        public ContactsController(ContactService contactService, IMediator mediator)
        {
            _contactService = contactService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var _request = new ContactGetAllRequest();
            var _result = await _mediator.Send(_request);
            return Ok(_result);
        }
            

        [HttpGet("{id:length(24)}", Name = "Getcontact")]
        public async Task<IActionResult> Get(string id)
        {
            var _request = new ContactGetByIdRequest(id);
            var _result = await _mediator.Send(_request);
            return _result != null ? (IActionResult) Ok(_result) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> Create(ContactCreateRequest request)
        {
            var _result = await _mediator.Send(request);
            return CreatedAtRoute("GetContact", new { id = _result.Id.ToString() }, _result);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(ContactUpdateRequest request)
        {
            var _result = await _mediator.Send(request);
            return _result != null ? (IActionResult) Ok(_result) : NotFound();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var _request = new ContactDeleteRequest(id);
            var _result = await _mediator.Send(_request);
            return _result.DeleteRecords > 0 ? (IActionResult) Ok(_result) : NotFound();
        }
    }
}