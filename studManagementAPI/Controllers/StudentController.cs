using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using studManagementAPI.Models;
using studManagementAPI.Services;

namespace studManagementAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(Student student)
        {
            await _service.Add(student);
            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Student student)
        {
            await _service.Update(student);
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
