using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/marks")]
    [Controller]
    public class MarksController : ControllerBase
    {
        private readonly IRepository _repository;

        public MarksController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Mark> GetMarks()
        {
            return _repository.GetMarks();
        }

        [HttpGet]
        [Route("{id}")]
        public Mark GetMark(int id)
        {
            return _repository.GetMark(id);
        }

        // Create
        [HttpPost]
        public void CreateMark([FromBody]Mark mark)
        {
            _repository.CreateMark(mark);
        }
    }
}
