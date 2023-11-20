using GradingDB.Models;
using GradingDbApi.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GradingDbApi.Controllers
{
    [Route("api/students")]
    [Controller]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository _repository;

        public StudentsController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            try
            {
                return Ok(_repository.GetStudents());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Student> GetStudent(int id)
        { 
            try
            {
                Student stud = _repository.GetStudent(id);

                if (stud == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(stud);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Create
        [HttpPost]
        public IActionResult CreateStudent([FromBody]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateStudent(student);
                    return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
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
        public IActionResult UpdateStudent(int id, [FromBody] Student student)
        {
            try
            {
                Student updatedStudent = _repository.UpdateStudent(id, student);

                if (updatedStudent == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(GetStudent), new { id = updatedStudent.Id }, updatedStudent);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Student> DeleteStudent(int id)
        {

            try
            {
                bool deleteSuccess = _repository.DeleteStudent(id);

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
