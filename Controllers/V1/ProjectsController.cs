using System.Collections.Generic;
using System.Threading.Tasks;
using curly.Api.Models.Database;
using curly.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace curly.Api.Controllers.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _projectsService;
        

        public ProjectsController(ProjectService projectsService)
        {
            _projectsService = projectsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> Get()
        {
            var projects = await _projectsService.GetAllAsync();
            return projects;
        }
            
        [HttpGet("{id:length(24)}", Name = "GetProject")]
        public async Task<ActionResult<Project>> Get(string id)
        {
            var project = await _projectsService.GetByIdAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return project;
        }

        [HttpPost]
        public async Task<ActionResult<Project>> Create(Project project)
        {
            var newProject = await _projectsService.InsertOrUpdateAsync(project);

            return CreatedAtRoute("GetProject", new { id = newProject.Id.ToString() }, newProject);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(Project projectIn)
        {
            var project = await _projectsService.GetByIdAsync(projectIn.Id);

            if (project == null)
            {
                return NotFound();
            }

            await _projectsService.InsertOrUpdateAsync(projectIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var project = _projectsService.GetByIdAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            await _projectsService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}