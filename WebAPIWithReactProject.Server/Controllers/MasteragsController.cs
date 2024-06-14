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
    public class MasteragsController: ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public MasteragsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/HelperDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Masterag>>> GetHelperDetails()
        {
            return await _context.Masterags.ToListAsync();
        }

        // GET: api/HelperDetails/CheckAccessGroup/{agname}
        [HttpGet("CheckAccessGroup/{agname}")]
        public async Task<IActionResult> CheckAccessGroup(string agname)
        {
            var exists = await _context.Masterags.AnyAsync(e => e.Agname == agname);
            return Ok(new { exists });
        }



        // POST: api/HelperDetails

        [HttpPost]
        public async Task<ActionResult<Masterag>> PostHelperDetailsC(Masterag des)
        {
            // Check if a Category with the same name already exists

            if (_context.Masterags.Any(c => c.Agid == des.Agid))
            {
                return Conflict(new { message = $"A group with the name '{des.Agid}' already exists." });
            }

            var newHelperDetailsMaster = new Masterag
            {
                Agname = des.Agname,
                Details = des.Details,

            };

            _context.Masterags.Add(newHelperDetailsMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHelperDetails", new { id = newHelperDetailsMaster.Agid }, newHelperDetailsMaster);
        }

        // PUT: api/HelperDetails/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHelperDetails(int id, Masterag des)
        {
            if (id != des.Agid)
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



        private bool HelperDetailsExists(int id)
        {
            return _context.Masterags.Any(e => e.Agid == id);
        }
    }
}
