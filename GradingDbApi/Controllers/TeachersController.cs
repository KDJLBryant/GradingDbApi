using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/teachers")]
    [Controller]
    public class TeachersController
    {
        private readonly IRepository _repository;

        public TeachersController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Teacher> GetTeachers()
        {
            return _repository.GetTeachers();
        }

        [HttpGet]
        [Route("{id}")]
        public Teacher GetTeacher(int id)
        {
            return _repository.GetTeacher(id);
        }

        // Create
        [HttpPost]
        public void CreateTeacher([FromBody]Teacher teacher)
        {
            _repository.CreateTeacher(teacher);
        }
    }
}
