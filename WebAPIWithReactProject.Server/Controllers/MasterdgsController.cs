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
    public class MasterdgsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public MasterdgsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/HelperDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Masterdg>>> GetHelperDetails()
        {
            return await _context.Masterdgs.ToListAsync();
        }

        // GET: api/HelperDetails/CheckAccessGroup/{agname}
        [HttpGet("CheckAccessGroup/{dgname}")]
        public async Task<IActionResult> CheckAccessGroup(string dgname)
        {
            var exists = await _context.Masterdgs.AnyAsync(e => e.Dgname == dgname);
            return Ok(new { exists });
        }



        // POST: api/HelperDetails

        [HttpPost]
        public async Task<ActionResult<Masterdg>> PostHelperDetailsC(Masterdg des)
        {
            // Check if a Category with the same name already exists

            if (_context.Masterdgs.Any(c => c.Dgid == des.Dgid))
            {
                return Conflict(new { message = $"A group with the name '{des.Dgid}' already exists." });
            }

            var newHelperDetailsMaster = new Masterdg
            {
                Dgname = des.Dgname,
                Details = des.Details,

            };

            _context.Masterdgs.Add(newHelperDetailsMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHelperDetails", new { id = newHelperDetailsMaster.Dgid }, newHelperDetailsMaster);
        }

        // PUT: api/HelperDetails/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHelperDetails(int id, Masterdg des)
        {
            if (id != des.Dgid)
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
            var cat = await _context.Masterdgs.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.Masterdgs.Remove(cat);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool HelperDetailsExists(int id)
        {
            return _context.Masterdgs.Any(e => e.Dgid == id);
        }
    }
}
