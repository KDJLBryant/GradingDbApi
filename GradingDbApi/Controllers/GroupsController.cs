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
        public ActionResult<List<Group>> GetGroups()
        {
            try
            {
                return Ok(_repository.GetGroups());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Group> GetGroup(int id)
        {
            try
            {
                Group g = _repository.GetGroup(id);

                if (g == null) 
                {
                    return NotFound();
                }
                else
                {
                    return Ok(g);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // Create
        [HttpPost]
        public IActionResult CreateGroup([FromBody]Group group)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateGroup(group);
                    //return Created("..", group);
                    return CreatedAtAction(nameof(GetGroup), new { id = group.Id }, group);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception) 
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateGroup(int id, [FromBody]Group group)
        {
            try
            {
                Group updatedGroup = _repository.UpdateGroup(id, group);

                if (updatedGroup == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(GetGroup), new { id = updatedGroup.Id }, updatedGroup);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Group> DeleteGroup(int id)
        {

            try
            {
                bool deleteSuccess = _repository.DeleteGroup(id);

                if (deleteSuccess)
                {
                    return NoContent();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
