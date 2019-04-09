using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCServicesSima.Models;
using MVCServicesSima.Web.Api.BasicInfo.Models;

namespace MVCServicesSima.Web.Api.BasicInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentSpousesController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public StudentSpousesController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/StudentSpouses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentSpouse>>> GetStudentSpouse()
        {
            return await _context.StudentSpouse.ToListAsync();
        }

        // GET: api/StudentSpouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentSpouse>> GetStudentSpouse(long id)
        {
            var studentSpouse = await _context.StudentSpouse.FindAsync(id);

            if (studentSpouse == null)
            {
                return NotFound();
            }

            return studentSpouse;
        }

        // PUT: api/StudentSpouses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentSpouse(long id, StudentSpouse studentSpouse)
        {
            if (id != studentSpouse.SpouseId)
            {
                return BadRequest();
            }

            _context.Entry(studentSpouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentSpouseExists(id))
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

        // POST: api/StudentSpouses
        [HttpPost]
        public async Task<ActionResult<StudentSpouse>> PostStudentSpouse(StudentSpouse studentSpouse)
        {
            _context.StudentSpouse.Add(studentSpouse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentSpouse", new { id = studentSpouse.SpouseId }, studentSpouse);
        }

        // DELETE: api/StudentSpouses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentSpouse>> DeleteStudentSpouse(long id)
        {
            var studentSpouse = await _context.StudentSpouse.FindAsync(id);
            if (studentSpouse == null)
            {
                return NotFound();
            }

            _context.StudentSpouse.Remove(studentSpouse);
            await _context.SaveChangesAsync();

            return studentSpouse;
        }

        private bool StudentSpouseExists(long id)
        {
            return _context.StudentSpouse.Any(e => e.SpouseId == id);
        }
    }
}
