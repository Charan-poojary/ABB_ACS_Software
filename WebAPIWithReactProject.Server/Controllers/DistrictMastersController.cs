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
    public class DistrictsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public DistrictsController()
        {
            _context = new BpclWarangalAuditDbContext();
        }

        // GET: api/Districts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DistrictMaster>>> GetDistricts()
        {
            return await _context.DistrictMasters.ToListAsync();
        }


        // POST: api/Districts/CheckDistricts/{districtname}

        [HttpGet("CheckDistricts/{districtname}")]
        public async Task<IActionResult> CheckDistricts(string districtname)
        {
            var exists = await _context.DistrictMasters.AnyAsync(cm => cm.Districtname == districtname);
            return Ok(new { exists });
        }


        // POST: api/Districts

        [HttpPost]
        public async Task<ActionResult<StateMaster>> PostDistricts(DistrictMaster des)
        {
            // Check if a Locations with the same name already exists

            if (_context.DistrictMasters.Any(c => c.Districtname == des.Districtname))
            {
                return Conflict(new { message = $"A location with the name '{des.Districtname}' already exists." });
            }

            var newDistrictMaster = new DistrictMaster
            {
                Districtname = des.Districtname,

            };

            _context.DistrictMasters.Add(newDistrictMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistricts", new { id = newDistrictMaster.Srno }, newDistrictMaster);
        }

        // PUT: api/Districts/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistricts(int id, DistrictMaster des)
        {
            if (id != des.Srno)
            {
                return BadRequest();
            }

            _context.Entry(des).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistrictsExists(id))
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

        // DELETE: api/Districts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistricts(int id)
        {
            var district = await _context.DistrictMasters.FindAsync(id);
            if (district == null)
            {
                return NotFound();
            }

            _context.DistrictMasters.Remove(district);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool DistrictsExists(int id)
        {
            return _context.DistrictMasters.Any(e => e.Srno == id);
        }
    }
}
