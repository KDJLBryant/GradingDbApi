using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/teachers")]
    [Controller]
    public class TeachersController : ControllerBase
    {
        private readonly IRepository _repository;

        public TeachersController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Teacher>> GetTeachers()
        {
            try
            {
                return Ok(_repository.GetTeachers());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Teacher> GetTeacher(int id)
        {
            try
            {
                Teacher t = _repository.GetTeacher(id);

                if (t == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(t);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Create
        [HttpPost]
        public IActionResult CreateTeacher([FromBody]Teacher teacher)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateTeacher(teacher);
                    return CreatedAtAction(nameof(GetTeacher), new { id = teacher.Id }, teacher);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateGroup(int id, [FromBody]Teacher teacher)
        {
            try
            {
                Teacher updatedTeacher = _repository.UpdateTeacher(id, teacher);

                if (updatedTeacher == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(GetTeacher), new { id = updatedTeacher.Id }, updatedTeacher);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Teacher> DeleteTeacher(int id)
        {

            try
            {
                bool deleteSuccess = _repository.DeleteTeacher(id);

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
