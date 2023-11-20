using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Web.WebPages.Html;

namespace GradingDbApi.Controllers
{
    [Route("api/subjects")]
    [Controller]
    public class SubjectsController : ControllerBase
    {
        private readonly IRepository _repository;

        public SubjectsController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Subject>> GetSubjects()
        {
            try
            {
                return Ok(_repository.GetSubjects());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Subject> GetSubject(int id)
        {
            try
            {
                Subject sub = _repository.GetSubject(id);

                if (sub != null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(sub);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Create
        [HttpPost]
        public IActionResult CreateSubject([FromBody]Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateSubject(subject);
                    return CreatedAtAction(nameof(GetSubject), new { id = subject.Id }, subject);
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
        public IActionResult UpdateSubject(int id, [FromBody] Subject subject)
        {
            try
            {
                Subject updatedSubject = _repository.UpdateSubject(id, subject);

                if (updatedSubject == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(GetSubject), new { id = updatedSubject.Id }, updatedSubject);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Subject> DeleteSubject(int id)
        {

            try
            {
                bool deleteSuccess = _repository.DeleteSubject(id);

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
