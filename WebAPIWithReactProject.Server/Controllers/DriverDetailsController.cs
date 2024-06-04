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
    public class DriverDetailsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public DriverDetailsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/DriverDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverDetail>>> GetDriverDetails()
        {
            return await _context.DriverDetails.ToListAsync();
        }

        // GET: api/DriverDetails/CheckEmployeeByEmpcode/{empcode}
        [HttpGet("CheckEmployeeByEmpcode/{empcode}")]
        public async Task<IActionResult> CheckEmployeeByEmpcode(string empcode)
        {
            var exists = await _context.DriverDetails.AnyAsync(e => e.Empcode == empcode);
            return Ok(new { exists });
        }

        // GET: api/DriverDetails/CheckEmployeeByEnrollno/{enrollno}
        [HttpGet("CheckEmployeeByCardno/{cardno}")]
        public async Task<IActionResult> CheckEmployeeByEnrollno(string cardno)
        {
            var exists = await _context.DriverDetails.AnyAsync(e => e.Cardno == cardno);
            return Ok(new { exists });
        }



        // POST: api/DriverDetails

        [HttpPost]
        public async Task<ActionResult<DriverDetail>> PostDriverDetailsC(DriverDetail des)
        {
            // Check if a Category with the same name already exists

            if (_context.DriverDetails.Any(c => c.Empcode == des.Empcode))
            {
                return Conflict(new { message = $"A location with the name '{des.Empcode}' already exists." });
            }

            var newDriverDetailsMaster = new DriverDetail
            {
                Empcode = des.Empcode,
                Name = des.Name,
                Cardno = des.Cardno,
                Pin = des.Pin,
                Otlno = des.Otlno,

            };

            _context.DriverDetails.Add(newDriverDetailsMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDriverDetails", new { id = newDriverDetailsMaster.Empid }, newDriverDetailsMaster);
        }

        // PUT: api/DriverDetails/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriverDetails(int id, DriverDetail des)
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
                if (!DriverDetailsExists(id))
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

        // DELETE: api/DriverDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeCategory(int id)
        {
            var cat = await _context.DriverDetails.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.DriverDetails.Remove(cat);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // Search: api/DriverDetails/Search
        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<DriverDetail>>> SearchDriverDetails(string empcode = "", string name = "", string cardno = "")
        {
            var query = _context.DriverDetails.AsQueryable();

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


        private bool DriverDetailsExists(int id)
        {
            return _context.DriverDetails.Any(e => e.Empid == id);
        }
    }
}
