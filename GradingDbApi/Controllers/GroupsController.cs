using GradingDB.Models;
using GradingDbApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/groups")]
    [Controller]
    public class GroupsController : ControllerBase
    {
        private readonly SchoolRepository _repository;

        public GroupsController()
        {
            _repository = new SchoolRepository();
        }

        [HttpGet]
        public List<Group> GetGroups()
        {
            return _repository.GetGroups();
        }

        [HttpGet]
        [Route("{id}")]
        public Group GetGroup(int id)
        {
            return _repository.GetGroup(id);
        }
    }
}
