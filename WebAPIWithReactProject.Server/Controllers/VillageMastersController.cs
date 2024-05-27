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
    public class VillagesController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public VillagesController(BpclWarangalAuditDbContext context)
        {
            _context =context ;
        }

        // GET: api/Villages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VillageMaster>>> GetVillages()
        {
            return await _context.VillageMasters.ToListAsync();
        }


        // POST: api/Villages/CheckVillages/{}

        [HttpGet("CheckVillages/{villagename}")]
        public async Task<IActionResult> CheckVillages(string villagename)
        {
            var exists = await _context.VillageMasters.AnyAsync(cm => cm.Villagename == villagename);
            return Ok(new { exists });
        }


        // POST: api/Villages

        [HttpPost]
        public async Task<ActionResult<VillageMaster>> PostVillages(VillageMaster des)
        {
            // Check if a Locations with the same name already exists

            if (_context.VillageMasters.Any(c => c.Villagename == des.Villagename))
            {
                return Conflict(new { message = $"A location with the name '{des.Villagename}' already exists." });
            }

            var newVillagwMaster = new VillageMaster
            {
                Villagename = des.Villagename,

            };

            _context.VillageMasters.Add(newVillagwMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVillages", new { id = newVillagwMaster.SrNo }, newVillagwMaster);
        }

        // PUT: api/Villages/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVillages(int id, VillageMaster des)
        {
            if (id != des.SrNo)
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
                if (!VillagesExists(id))
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

        // DELETE: api/Villages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVillages(int id)
        {
            var village = await _context.VillageMasters.FindAsync(id);
            if (village == null)
            {
                return NotFound();
            }

            _context.VillageMasters.Remove(village);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool VillagesExists(int id)
        {
            return _context.VillageMasters.Any(e => e.SrNo == id);
        }
    }
}
