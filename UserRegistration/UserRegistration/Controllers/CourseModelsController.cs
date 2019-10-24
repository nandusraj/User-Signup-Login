using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseModelsController : ControllerBase
    {
        private readonly CourseContext _context;

        public CourseModelsController(CourseContext context)
        {
            _context = context;
        }

        // GET: api/CourseModels
        [HttpGet]
        public IEnumerable<CourseModel> GetCourseModels()
        {
            return _context.CourseModels;
        }

        // GET: api/CourseModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseModel = await _context.CourseModels.FindAsync(id);

            if (courseModel == null)
            {
                return NotFound();
            }

            return Ok(courseModel);
        }

        // PUT: api/CourseModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseModel([FromRoute] int id, [FromBody] CourseModel courseModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseModel.cid)
            {
                return BadRequest();
            }

            _context.Entry(courseModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CourseModels
        [HttpPost]
        public async Task<IActionResult> PostCourseModel([FromBody] CourseModel courseModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CourseModels.Add(courseModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourseModel", new { id = courseModel.cid }, courseModel);
        }

        // DELETE: api/CourseModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseModel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseModel = await _context.CourseModels.FindAsync(id);
            if (courseModel == null)
            {
                return NotFound();
            }

            _context.CourseModels.Remove(courseModel);
            await _context.SaveChangesAsync();

            return Ok(courseModel);
        }

        private bool CourseModelExists(int id)
        {
            return _context.CourseModels.Any(e => e.cid == id);
        }
    }
}