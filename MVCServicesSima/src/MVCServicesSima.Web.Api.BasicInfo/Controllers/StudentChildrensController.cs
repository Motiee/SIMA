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
    public class StudentChildrensController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public StudentChildrensController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/StudentChildrens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentChildren>>> GetStudentChildren()
        {
            return await _context.StudentChildren.ToListAsync();
        }

        // GET: api/StudentChildrens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentChildren>> GetStudentChildren(long id)
        {
            var studentChildren = await _context.StudentChildren.FindAsync(id);

            if (studentChildren == null)
            {
                return NotFound();
            }

            return studentChildren;
        }

        // PUT: api/StudentChildrens/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentChildren(long id, StudentChildren studentChildren)
        {
            if (id != studentChildren.ChildId)
            {
                return BadRequest();
            }

            _context.Entry(studentChildren).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentChildrenExists(id))
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

        // POST: api/StudentChildrens
        [HttpPost]
        public async Task<ActionResult<StudentChildren>> PostStudentChildren(StudentChildren studentChildren)
        {
            _context.StudentChildren.Add(studentChildren);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentChildren", new { id = studentChildren.ChildId }, studentChildren);
        }

        // DELETE: api/StudentChildrens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentChildren>> DeleteStudentChildren(long id)
        {
            var studentChildren = await _context.StudentChildren.FindAsync(id);
            if (studentChildren == null)
            {
                return NotFound();
            }

            _context.StudentChildren.Remove(studentChildren);
            await _context.SaveChangesAsync();

            return studentChildren;
        }

        private bool StudentChildrenExists(long id)
        {
            return _context.StudentChildren.Any(e => e.ChildId == id);
        }
    }
}
