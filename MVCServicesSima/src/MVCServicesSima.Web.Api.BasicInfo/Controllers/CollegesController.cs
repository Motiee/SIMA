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
    public class CollegesController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public CollegesController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/Colleges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<College>>> GetCollege()
        {
            return await _context.College.ToListAsync();
        }

        // GET: api/Colleges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<College>> GetCollege(int id)
        {
            var college = await _context.College.FindAsync(id);

            if (college == null)
            {
                return NotFound();
            }

            return college;
        }

        // PUT: api/Colleges/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollege(int id, College college)
        {
            if (id != college.CollegeId)
            {
                return BadRequest();
            }

            _context.Entry(college).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeExists(id))
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

        // POST: api/Colleges
        [HttpPost]
        public async Task<ActionResult<College>> PostCollege(College college)
        {
            _context.College.Add(college);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCollege", new { id = college.CollegeId }, college);
        }

        // DELETE: api/Colleges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<College>> DeleteCollege(int id)
        {
            var college = await _context.College.FindAsync(id);
            if (college == null)
            {
                return NotFound();
            }

            _context.College.Remove(college);
            await _context.SaveChangesAsync();

            return college;
        }

        private bool CollegeExists(int id)
        {
            return _context.College.Any(e => e.CollegeId == id);
        }
    }
}
