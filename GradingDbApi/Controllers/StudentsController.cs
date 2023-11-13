using GradingDB.Models;
using GradingDbApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/students")]
    [Controller]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolRepository _repository;

        public StudentsController()
        { 
            _repository = new SchoolRepository();
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
    }
}
