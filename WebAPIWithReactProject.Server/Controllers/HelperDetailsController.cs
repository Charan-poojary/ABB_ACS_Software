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
    public class HelperDetailsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public HelperDetailsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/HelperDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HelperDetail>>> GetHelperDetails()
        {
            return await _context.HelperDetails.ToListAsync();
        }

        // GET: api/HelperDetails/CheckEmployeeByEmpcode/{empcode}
        [HttpGet("CheckEmployeeByEmpcode/{empcode}")]
        public async Task<IActionResult> CheckEmployeeByEmpcode(string empcode)
        {
            var exists = await _context.HelperDetails.AnyAsync(e => e.Empcode == empcode);
            return Ok(new { exists });
        }

        // GET: api/HelperDetails/CheckEmployeeByEnrollno/{enrollno}
        [HttpGet("CheckEmployeeByCardno/{cardno}")]
        public async Task<IActionResult> CheckEmployeeByEnrollno(string cardno)
        {
            var exists = await _context.HelperDetails.AnyAsync(e => e.Cardno == cardno);
            return Ok(new { exists });
        }



        // POST: api/HelperDetails

        [HttpPost]
        public async Task<ActionResult<HelperDetail>> PostHelperDetailsC(HelperDetail des)
        {
            // Check if a Category with the same name already exists

            if (_context.HelperDetails.Any(c => c.Empcode == des.Empcode))
            {
                return Conflict(new { message = $"A location with the name '{des.Empcode}' already exists." });
            }

            var newHelperDetailsMaster = new HelperDetail
            {
                Empcode = des.Empcode,
                Name = des.Name,
                Cardno = des.Cardno,
                Pin = des.Pin,
                Otlno = des.Otlno,

            };

            _context.HelperDetails.Add(newHelperDetailsMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHelperDetails", new { id = newHelperDetailsMaster.Empid }, newHelperDetailsMaster);
        }

        // PUT: api/HelperDetails/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHelperDetails(int id, HelperDetail des)
        {
            if (id != des.Empid)
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
                if (!HelperDetailsExists(id))
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

        // DELETE: api/HelperDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeCategory(int id)
        {
            var cat = await _context.HelperDetails.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.HelperDetails.Remove(cat);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // Search: api/HelperDetails/Search
        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<HelperDetail>>> SearchHelperDetails(string empcode = "", string name = "", string cardno = "")
        {
            var query = _context.HelperDetails.AsQueryable();

            if (!string.IsNullOrEmpty(empcode))
            {
                query = query.Where(e => e.Empcode.Contains(empcode));
            }

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(cardno))
            {
                query = query.Where(e => e.Cardno.Contains(cardno));
            }

            return await query.ToListAsync();
        }


        private bool HelperDetailsExists(int id)
        {
            return _context.HelperDetails.Any(e => e.Empid == id);
        }
    }
}
