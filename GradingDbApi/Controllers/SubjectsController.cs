using GradingDB.Models;
using GradingDbApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    public class SubjectsController
    {
        private readonly SchoolRepository _repository;

        public SubjectsController()
        {
            _repository = new SchoolRepository();
        }

        [HttpGet]
        public List<Subject> GetSubjects()
        {
            return _repository.GetSubjects();
        }

        [HttpGet]
        [Route("{id}")]
        public Subject GetSubject(int id)
        {
            return _repository.GetSubject(id);
        }
    }
}
