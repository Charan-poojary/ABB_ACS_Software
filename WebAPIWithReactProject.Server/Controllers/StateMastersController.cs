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
    public class StatesController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public StatesController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/States
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StateMaster>>> GetStates()
        {
            return await _context.StateMasters.ToListAsync();
        }


        // POST: api/States/CheckStates/{statename}

        [HttpGet("CheckStates/{statename}")]
        public async Task<IActionResult> CheckStates(string statename)
        {
            var exists = await _context.StateMasters.AnyAsync(cm => cm.Statename == statename);
            return Ok(new { exists });
        }


        // POST: api/States

        [HttpPost]
        public async Task<ActionResult<StateMaster>> PostStates(StateMaster des)
        {
            // Check if a Locations with the same name already exists

            if (_context.StateMasters.Any(c => c.Statename == des.Statename))
            {
                return Conflict(new { message = $"A location with the name '{des.Statename}' already exists." });
            }

            var newStateMaster = new StateMaster
            {
                Statename = des.Statename,

            };

            _context.StateMasters.Add(newStateMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStates", new { id = newStateMaster.Srno }, newStateMaster);
        }

        // PUT: api/States/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStates(int id, StateMaster des)
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
                if (!StatesExists(id))
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

        // DELETE: api/States/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStates(int id)
        {
            var state = await _context.StateMasters.FindAsync(id);
            if (state == null)
            {
                return NotFound();
            }

            _context.StateMasters.Remove(state);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool StatesExists(int id)
        {
            return _context.StateMasters.Any(e => e.Srno == id);
        }
    }
}
