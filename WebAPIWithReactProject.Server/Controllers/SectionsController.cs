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
    public class SectionsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public SectionsController()
        {
            _context = new BpclWarangalAuditDbContext();
        }

        // GET: api/Sections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sectionmaster>>> GetSections()
        {
            return await _context.Sectionmasters.ToListAsync();
        }


        // POST: api/Sections/CheckSections/{sectionname}

        [HttpGet("CheckSections/{sectionname}")]
        public async Task<IActionResult> CheckSections(string sec)
        {
            var exists = await _context.Sectionmasters.AnyAsync(cm => cm.Sectionname == sec);
            return Ok(new { exists });
        }

        // POST: api/Sections

        [HttpPost]
        public async Task<ActionResult<Sectionmaster>> PostSections(Sectionmaster sec)
        {
            // Check if a Locations with the same name already exists

            if (_context.Sectionmasters.Any(c => c.Sectionname == sec.Sectionname))
            {
                return Conflict(new { message = $"A location with the name '{sec.Sectionname}' already exists." });
            }

            var newSectionMaster = new Sectionmaster
            {
                Sectionname = sec.Sectionname,
                Sectionhead = sec.Sectionhead,
                Email = sec.Email,
                Contactno = sec.Contactno,
            };

            _context.Sectionmasters.Add(newSectionMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSections", new { id = newSectionMaster.Srno }, newSectionMaster);
        }

        // PUT: api/Sections/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSections(int id, Sectionmaster sec)
        {
            if (id != sec.Srno)
            {
                return BadRequest();
            }

            _context.Entry(sec).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(id))
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
            var sect = await _context.Sectionmasters.FindAsync(id);
            if (sect == null)
            {
                return NotFound();
            }

            _context.Sectionmasters.Remove(sect);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool SectionExists(int id)
        {
            return _context.Sectionmasters.Any(e => e.Srno == id);
        }
    }
}
