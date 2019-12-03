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
            var address = await _addressService.GetByIdAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            return Ok(address);
        }

        [HttpPost]
        public async Task<ActionResult<Address>> Create(Address address)
        {
            var newAddress = await _addressService.InsertOrUpdateAsync(address);

            return CreatedAtRoute("GetAddress", new { id = newAddress.Id.ToString() }, newAddress);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(Address addressIn)
        {
            var address = await _addressService.GetByIdAsync(addressIn.Id);

            if (address == null)
            {
                return NotFound();
            }

            await _addressService.InsertOrUpdateAsync(addressIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var address = _addressService.GetByIdAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            await _addressService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}