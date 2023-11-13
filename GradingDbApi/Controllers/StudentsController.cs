using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/students")]
    [Controller]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository _repository;

        public StudentsController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _repository.GetStudents();
        }

        [HttpGet]
        [Route("{id}")]
        public Student GetStudent(int id)
        { 
            return _repository.GetStudent(id);
        }

        // Create
        [HttpPost]
        public void CreateStudent([FromBody]Student student)
        {
            _repository.CreateStudent(student);
        }
    }
}
