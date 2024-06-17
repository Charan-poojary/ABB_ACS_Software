using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIWithReactProject.Server.Models;

namespace WebAPIWithReactProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterControllers : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public MasterControllers(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/MasterControllers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mastercontroller>>> GetCompanyMasters()
        {
            return await _context.Mastercontrollers.ToListAsync();
        }
    }
}
