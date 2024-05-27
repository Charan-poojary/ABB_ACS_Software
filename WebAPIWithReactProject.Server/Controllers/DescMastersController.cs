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
    public class DesignationsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public DesignationsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/Designations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DescMaster>>> GetDesignations()
        {
            return await _context.DescMasters.ToListAsync();
        }


        // POST: api/Designations

        [HttpPost]
        public async Task<ActionResult<DescMaster>> PostDesignations(DescMaster des)
        {
            // Check if a Locations with the same name already exists

            if (_context.DescMasters.Any(c => c.Designation == des.Designation))
            {
                return Conflict(new { message = $"A location with the name '{des.Designation}' already exists." });
            }

            var newDesignationMaster = new DescMaster
            {
                Designation = des.Designation,

            };

            _context.DescMasters.Add(newDesignationMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDesignations", new { id = newDesignationMaster.SrNo }, newDesignationMaster);
        }

        // PUT: api/Designations/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDesignations(int id, DescMaster des)
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
                if (!DesignationsExists(id))
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

        // DELETE: api/Designations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDesignations(int id)
        {
            var desig = await _context.DescMasters.FindAsync(id);
            if (desig == null)
            {
                return NotFound();
            }

            _context.DescMasters.Remove(desig);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool DesignationsExists(int id)
        {
            return _context.DescMasters.Any(e => e.SrNo == id);
        }
    }
}
