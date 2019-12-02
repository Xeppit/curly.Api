using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curly.Api.Models.Models.Database;
using curly.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace curly.Api.Controllers.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PersonService _personService;

        public PeopleController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get() =>
            await _personService.GetAllAsync();

        [HttpGet("{id:length(24)}", Name = "GetPerson")]
        public async Task<ActionResult<Person>> Get(string id)
        {
            var person = await _personService.GetByIdAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpPost]
        public async Task<ActionResult<Person>> Create(Person person)
        {
            await _personService.InsertAsync(person);

            return CreatedAtRoute("GetPerson", new { id = person.Id.ToString() }, person);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(Person personIn)
        {
            var person = await _personService.GetByIdAsync(personIn.Id);

            if (person == null)
            {
                return NotFound();
            }

            await _personService.InsertOrUpdateAsync(personIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var person = await _personService.GetByIdAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            await _personService.DeleteByIdAsync(person.Id);

            return NoContent();
        }
    }
}
