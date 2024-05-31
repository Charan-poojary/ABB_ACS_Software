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

        public LocationsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/LocationMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationMaster>>> GetLocations()
        {
            return await _context.LocationMasters.ToListAsync();
        }


        // GET: api/Locations/Name/{id}
        [HttpGet("Name/{id}")]
        public async Task<ActionResult<string>> GetLocationName(int id)
        {
            var location = await _context.LocationMasters.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location.Locationid); 
        }

        // POST: api/LocationMasters/CheckLocations/{location}

        [HttpGet("CheckLocations/{locationid}")]
        public async Task<IActionResult> CheckLocations(string locationid)
        {
            var exists = await _context.LocationMasters.AnyAsync(cm => cm.Locationid == locationid);
            return Ok(new { exists });
        }

        // POST: api/LocationMasters

        [HttpPost]
        public async Task<ActionResult<LocationMaster>> PostLocations(LocationMaster loc)
        {
            // Check if a Locations with the same name already exists

            if (_context.LocationMasters.Any(c => c.Locationid == loc.Locationid))
            {
                return Conflict(new { message = $"A location with the name '{loc.Locationid}' already exists." });
            }

            var newLocationMaster = new LocationMaster
            {
                Locationid = loc.Locationid,
                Details = loc.Details,

            };

            _context.LocationMasters.Add(newLocationMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocations", new { id = newLocationMaster.Srno}, newLocationMaster);
        }

        // PUT: api/LocationMasters/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocations(int id, LocationMaster loc)
        {
            if (id != loc.Srno)
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

        // DELETE: api/LocationMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocations(int id)
        {
            var locations = await _context.LocationMasters.FindAsync(id);
            if (locations == null)
            {
                return NotFound();
            }

            _context.LocationMasters.Remove(locations);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool LocationExists(int id)
        {
            return _context.LocationMasters.Any(e => e.Srno == id);
        }
    }
}
