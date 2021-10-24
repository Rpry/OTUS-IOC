using System;
using System.Threading.Tasks;
using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController: ControllerBase
    {
        private ILessonService _service;

        public StudentController(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var lessonService1 = services.GetService<IStudentService>();
                var lessonService2 = services.GetService<IStudentService>();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}