using System.Threading.Tasks;
using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonController: ControllerBase
    {
        private ILessonService _service;

        public LessonController(ILessonService service)
        {
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}