using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/groups")]
    [Controller]
    public class GroupsController : ControllerBase
    {
        private readonly IRepository _repository;

        public GroupsController(IRepository repository)
        {
            _repository = repository;
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

        // Create
        [HttpPost]
        public void CreateGroup([FromBody]Group group)
        {
            if (ModelState.IsValid)
            {
                _repository.CreateGroup(group);
            }
        }
    }
}
