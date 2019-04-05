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
    public class CityController : ControllerBase
    {
        private readonly MVCServicesSimaWebApiBasicInfoContext _context;

        public CityController(MVCServicesSimaWebApiBasicInfoContext context)
        {
            _context = context;
        }

        // GET: api/City
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCity()
        {
            return await _context.City.ToListAsync();
        }

        // GET: api/City/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var City = await _context.City.FindAsync(id);

            if (City == null)
            {
                return NotFound();
            }

            return City;
        }

        // PUT: api/City/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, City City)
        {
            if (id != City.AreaId)
            {
                return BadRequest();
            }

            _context.Entry(City).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
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

        // POST: api/City
        [HttpPost]
        public async Task<ActionResult<City>> PostCity(City City)
        {
            _context.City.Add(City);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = City.AreaId }, City);
        }

        // DELETE: api/City/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<City>> DeleteCity(int id)
        {
            var City = await _context.City.FindAsync(id);
            if (City == null)
            {
                return NotFound();
            }

            _context.City.Remove(City);
            await _context.SaveChangesAsync();

            return City;
        }

        private bool CityExists(int id)
        {
            return _context.City.Any(e => e.AreaId == id);
        }
    }
}
