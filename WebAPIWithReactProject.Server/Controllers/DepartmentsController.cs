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
    public class DepartmentsController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public DepartmentsController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeptCode>>> GetDepartments()
        {
            return await _context.DeptCodes.ToListAsync();
        }

        // GET: api/Departments/Name/{id}
        [HttpGet("Name/{id}")]
        public async Task<ActionResult<string>> GetDepartmentName(int id)
        {
            var dept = await _context.DeptCodes.FindAsync(id);

            if (dept == null)
            {
                return NotFound();
            }

            return Ok(dept.DeptName); 
        }


        // GET: api/Departments/CheckDepartments/{deptname}

        [HttpGet("CheckDepartments/{deptname}")]
        public async Task<IActionResult> CheckDepartments(string deptname)
        {
            var exists = await _context.DeptCodes.AnyAsync(cm => cm.DeptName == deptname);
            return Ok(new { exists });
        }

        // POST: api/Departments

        [HttpPost]
        public async Task<ActionResult<DeptCode>> PostDepartments(DeptCode dp)
        {
            // Check if a Departments with the same name already exists

            if (_context.DeptCodes.Any(c => c.DeptName == dp.DeptName))
            {
                return Conflict(new { message = $"A department with the name '{dp.DeptName}' already exists." });
            }

            var newDepartmentMaster = new DeptCode
            {
                DeptName = dp.DeptName,

            };

            _context.DeptCodes.Add(newDepartmentMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartments", new { id = newDepartmentMaster.SrNo }, newDepartmentMaster);
        }

        // PUT: api/Departments/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartments(int id, DeptCode dp)
        {
            if (id != dp.SrNo)
            {
                return BadRequest();
            }

            _context.Entry(dp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartments(int id)
        {
            var dp = await _context.DeptCodes.FindAsync(id);
            if (dp == null)
            {
                return NotFound();
            }

            _context.DeptCodes.Remove(dp);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool DepartmentExists(int id)
        {
            return _context.DeptCodes.Any(e => e.SrNo == id);
        }
    }
}
