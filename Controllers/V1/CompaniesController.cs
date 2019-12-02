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
    public class CompaniesController : ControllerBase
    {
        private readonly CompanyService _companyService;

        public CompaniesController(CompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> Get() =>
            await _companyService.GetAllAsync();

        [HttpGet("{id:length(24)}", Name = "GetCompany")]
        public async Task<ActionResult<Company>> Get(string id)
        {
            var company = await _companyService.GetByIdAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        [HttpPost]
        public async Task<ActionResult<Company>> Create(Company company)
        {
            await _companyService.InsertAsync(company);

            return CreatedAtRoute("GetCompany", new { id = company.Id.ToString() }, company);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Company companyIn)
        {
            var company = await _companyService.GetByIdAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            await _companyService.InsertOrUpdateAsync(companyIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var company = await _companyService.GetByIdAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            await _companyService.DeleteByIdAsync(company.Id);

            return NoContent();
        }
    }
}
