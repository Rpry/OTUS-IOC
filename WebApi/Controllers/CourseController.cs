using System.Threading.Tasks;
using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController: ControllerBase
    {
        private ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}