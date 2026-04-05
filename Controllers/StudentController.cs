using Microsoft.AspNetCore.Mvc;
using ZestStudentAPI.Models;
using ZestStudentAPI.Repositories;

namespace ZestStudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _repository.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Student student)
        {
            student.CreatedDate = DateTime.Now;
            await _repository.Add(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Student student)
        {
            student.Id = id;
            await _repository.Update(student);
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return Ok();
        }
    }
}