using GradingDB.Models;
using GradingDbApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/marks")]
    [Controller]
    public class MarksController : ControllerBase
    {
        private readonly SchoolRepository _repository;

        public MarksController()
        {
            _repository = new SchoolRepository();
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
    }
}
