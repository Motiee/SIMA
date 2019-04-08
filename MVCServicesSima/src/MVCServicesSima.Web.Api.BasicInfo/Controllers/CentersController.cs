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
    public class CentersController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public CentersController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/Centers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Center>>> GetCenter()
        {
            return await _context.Center.ToListAsync();
        }

        // GET: api/Centers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Center>> GetCenter(int id)
        {
            var center = await _context.Center.FindAsync(id);

            if (center == null)
            {
                return NotFound();
            }

            return center;
        }

        // PUT: api/Centers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCenter(int id, Center center)
        {
            if (id != center.CenterId)
            {
                return BadRequest();
            }

            _context.Entry(center).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CenterExists(id))
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

        // POST: api/Centers
        [HttpPost]
        public async Task<ActionResult<Center>> PostCenter(Center center)
        {
            _context.Center.Add(center);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCenter", new { id = center.CenterId }, center);
        }

        // DELETE: api/Centers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Center>> DeleteCenter(int id)
        {
            var center = await _context.Center.FindAsync(id);
            if (center == null)
            {
                return NotFound();
            }

            _context.Center.Remove(center);
            await _context.SaveChangesAsync();

            return center;
        }

        private bool CenterExists(int id)
        {
            return _context.Center.Any(e => e.CenterId == id);
        }
    }
}
