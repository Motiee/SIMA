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
    public class UniversitiesController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public UniversitiesController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/Universities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<University>>> GetUniversity()
        {
            return await _context.University.ToListAsync();
        }

        // GET: api/Universities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<University>> GetUniversity(int id)
        {
            var university = await _context.University.FindAsync(id);

            if (university == null)
            {
                return NotFound();
            }

            return university;
        }

        // PUT: api/Universities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniversity(int id, University university)
        {
            if (id != university.UniversityId)
            {
                return BadRequest();
            }

            _context.Entry(university).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversityExists(id))
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

        // POST: api/Universities
        [HttpPost]
        public async Task<ActionResult<University>> PostUniversity(University university)
        {
            _context.University.Add(university);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniversity", new { id = university.UniversityId }, university);
        }

        // DELETE: api/Universities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<University>> DeleteUniversity(int id)
        {
            var university = await _context.University.FindAsync(id);
            if (university == null)
            {
                return NotFound();
            }

            _context.University.Remove(university);
            await _context.SaveChangesAsync();

            return university;
        }

        private bool UniversityExists(int id)
        {
            return _context.University.Any(e => e.UniversityId == id);
        }
    }
}
