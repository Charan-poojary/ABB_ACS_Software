using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAPIWithReactProject.Server.Models;

namespace WebAPIWithReactProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public LocationsController()
        {
            _context = new BpclWarangalAuditDbContext();
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }


        // POST: api/Locations/CheckLocations/{location}

        [HttpGet("CheckLocations/{location1}")]
        public async Task<IActionResult> CheckLocations(string location1)
        {
            var exists = await _context.Locations.AnyAsync(cm => cm.Location1 == location1);
            return Ok(new { exists });
        }

        // POST: api/Locations

        [HttpPost]
        public async Task<ActionResult<Location>> PostLocations(Location loc)
        {
            // Check if a Locations with the same name already exists

            if (_context.Locations.Any(c => c.Location1 == loc.Location1))
            {
                return Conflict(new { message = $"A location with the name '{loc.Location1}' already exists." });
            }

            var newLocationMaster = new Location
            {
                Location1 = loc.Location1,
                Details = loc.Details,

            };

            _context.Locations.Add(newLocationMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocations", new { id = newLocationMaster.SrNo }, newLocationMaster);
        }

        // PUT: api/Locations/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocations(int id, Location loc)
        {
            if (id != loc.SrNo)
            {
                return BadRequest();
            }

            _context.Entry(loc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocations(int id)
        {
            var locations = await _context.Locations.FindAsync(id);
            if (locations == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(locations);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.SrNo == id);
        }
    }
}
