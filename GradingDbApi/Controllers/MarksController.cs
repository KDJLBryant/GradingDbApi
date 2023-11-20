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
        public ActionResult<List<Mark>> GetMarks()
        {
            try
            {
                return Ok(_repository.GetMarks());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Mark> GetMark(int id)
        {
            try
            {

                Mark m = _repository.GetMark(id);

                if (m == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(m);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Create
        [HttpPost]
        public IActionResult CreateMark([FromBody]Mark mark)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateMark(mark);
                    return CreatedAtAction(nameof(GetMark), new { id = mark.Id }, mark);
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
        public IActionResult UpdateMark(int id, [FromBody] Mark mark)
        {
            try
            {
                Mark updatedMark = _repository.UpdateMark(id, mark);

                if (updatedMark == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(GetMark), new { id = updatedMark.Id }, updatedMark);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Mark> DeleteMark(int id)
        {

            try
            {
                bool deleteSuccess = _repository.DeleteMark(id);

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
