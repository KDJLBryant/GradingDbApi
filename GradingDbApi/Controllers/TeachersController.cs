using GradingDB.Models;
using GradingDbApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/teachers")]
    [Controller]
    public class TeachersController
    {
        private readonly SchoolRepository _repository;

        public TeachersController()
        {
            _repository = new SchoolRepository();
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
    }
}
