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
    public class CollegeGroupsController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public CollegeGroupsController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/CollegeGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollegeGroup>>> GetCollegeGroup()
        {
            return await _context.CollegeGroup.ToListAsync();
        }

        // GET: api/CollegeGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CollegeGroup>> GetCollegeGroup(int id)
        {
            var collegeGroup = await _context.CollegeGroup.FindAsync(id);

            if (collegeGroup == null)
            {
                return NotFound();
            }

            return collegeGroup;
        }

        // PUT: api/CollegeGroups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollegeGroup(int id, CollegeGroup collegeGroup)
        {
            if (id != collegeGroup.CollegeId)
            {
                return BadRequest();
            }

            _context.Entry(collegeGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeGroupExists(id))
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

        // POST: api/CollegeGroups
        [HttpPost]
        public async Task<ActionResult<CollegeGroup>> PostCollegeGroup(CollegeGroup collegeGroup)
        {
            _context.CollegeGroup.Add(collegeGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCollegeGroup", new { id = collegeGroup.CollegeId }, collegeGroup);
        }

        // DELETE: api/CollegeGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CollegeGroup>> DeleteCollegeGroup(int id)
        {
            var collegeGroup = await _context.CollegeGroup.FindAsync(id);
            if (collegeGroup == null)
            {
                return NotFound();
            }

            _context.CollegeGroup.Remove(collegeGroup);
            await _context.SaveChangesAsync();

            return collegeGroup;
        }

        private bool CollegeGroupExists(int id)
        {
            return _context.CollegeGroup.Any(e => e.CollegeId == id);
        }
    }
}
