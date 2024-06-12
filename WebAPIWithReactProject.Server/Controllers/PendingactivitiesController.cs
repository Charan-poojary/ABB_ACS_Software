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
    public class PendingActivityController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public PendingActivityController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/Pendingactivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pendingactivity>>> GetPendingActivities()
        {
            return await _context.Pendingactivities.ToListAsync();
        }



        // DELETE: api/Pendingactivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePendingActivities(int id)
        {
            var activity = await _context.Pendingactivities.FindAsync(id);
            if (activity == null)
            {
                return NotFound();
            }

            _context.Pendingactivities.Remove(activity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
