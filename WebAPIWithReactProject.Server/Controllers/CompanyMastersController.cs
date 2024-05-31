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
    public class CompanyMastersController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public CompanyMastersController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/CompanyMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyMaster>>> GetCompanyMasters()
        {
            return await _context.CompanyMasters.ToListAsync();
        }
        // GET: api/CompanyMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetCompanyMasterName(int id)
        {
            var companyMaster = await _context.CompanyMasters.FindAsync(id);

            if (companyMaster == null)
            {
                return NotFound();
            }

            return Ok(companyMaster.Compname); // Return only the company name
        }

        // POST: api/CompanyMasters/CheckCompanyName/{compname}
        [HttpGet("CheckCompanyName/{compname}")]
        public async Task<IActionResult> CheckCompanyName(string compname)
        {
            var exists = await _context.CompanyMasters.AnyAsync(cm => cm.Compname == compname);
            return Ok(new { exists });
        }

        // POST: api/CompanyMasters
        [HttpPost]
        public async Task<ActionResult<CompanyMaster>> PostCompanyMaster(CompanyMaster companyMaster)
        {
            // Check if a company with the same name already exists
            if (_context.CompanyMasters.Any(c => c.Compname == companyMaster.Compname))
            {
                return Conflict(new { message = $"A company with the name '{companyMaster.Compname}' already exists." });
            }

            var newCompanyMaster = new CompanyMaster
            {
                Compname = companyMaster.Compname,
                Details = companyMaster.Details,
                Phno = companyMaster.Phno,
                Emailid = companyMaster.Emailid
            };

            _context.CompanyMasters.Add(newCompanyMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanyMaster", new { id = newCompanyMaster.Srno }, newCompanyMaster);
        }

        // PUT: api/CompanyMasters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyMaster(int id, CompanyMaster companyMaster)
        {
            if (id != companyMaster.Srno)
            {
                return BadRequest();
            }

            _context.Entry(companyMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyMasterExists(id))
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

        // DELETE: api/CompanyMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyMaster(int id)
        {
            var companyMaster = await _context.CompanyMasters.FindAsync(id);
            if (companyMaster == null)
            {
                return NotFound();
            }

            _context.CompanyMasters.Remove(companyMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyMasterExists(int id)
        {
            return _context.CompanyMasters.Any(e => e.Srno == id);
        }
    }
}
