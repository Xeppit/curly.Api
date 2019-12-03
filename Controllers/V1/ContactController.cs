using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curly.Api.Models.Database;
using curly.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace curly.Api.Controllers.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactService _contactService;

        public ContactsController(ContactService contactService)
        {
            _contactService = contactService;
        }

        // [HttpGet]
        // public async Task<ActionResult<List<Contact>>> Get() =>
        //     await _contactService.GetAllAsync();

        [HttpGet("{id:length(24)}", Name = "GetContact")]
        public async Task<ActionResult<Contact>> Get(string id)
        {
            var contact = await _contactService.GetByIdAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> Create(Contact contact)
        {
            await _contactService.InsertAsync(contact);

            return CreatedAtRoute("GetContact", new { id = contact.Id.ToString() }, contact);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(Contact contactIn)
        {
            var contact = await _contactService.GetByIdAsync(contactIn.Id);

            if (contact == null)
            {
                return NotFound();
            }

            await _contactService.InsertOrUpdateAsync(contactIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var contact = await _contactService.GetByIdAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            await _contactService.DeleteByIdAsync(contact.Id);

            return NoContent();
        }
    }
}
