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

        public DepartmentsController()
        {
            _context = new BpclWarangalAuditDbContext();
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }


        // POST: api/Departments/CheckDepartments/{deptname}

        [HttpGet("CheckDepartments/{deptname}")]
        public async Task<IActionResult> CheckDepartments(string deptname)
        {
            var exists = await _context.Departments.AnyAsync(cm => cm.Deptname == deptname);
            return Ok(new { exists });
        }

        // POST: api/Departments

        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartments(Department dp)
        {
            // Check if a Departments with the same name already exists

            if (_context.Departments.Any(c => c.Deptname == dp.Deptname))
            {
                return Conflict(new { message = $"A department with the name '{dp.Deptname}' already exists." });
            }

            var newDepartmentMaster = new Department
            {
                Deptname = dp.Deptname,

            };

            _context.Departments.Add(newDepartmentMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartments", new { id = newDepartmentMaster.SrNo }, newDepartmentMaster);
        }

        // PUT: api/Departments/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartments(int id, Department dp)
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
            var dp = await _context.Departments.FindAsync(id);
            if (dp == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(dp);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.SrNo == id);
        }
    }
}
