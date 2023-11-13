using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/subjects")]
    [Controller]
    public class SubjectsController
    {
        private readonly IRepository _repository;

        public SubjectsController(IRepository repository)
        {
            _repository = repository;
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

        // Create
        [HttpPost]
        public void CreateSubject([FromBody]Subject subject)
        {
            _repository.CreateSubject(subject);
        }
    }
}
