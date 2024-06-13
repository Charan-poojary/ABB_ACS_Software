using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using WebAPIWithReactProject.Server.Models;

namespace WebAPIWithReactProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MastercardinventoriesController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public MastercardinventoriesController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }
        

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mastercardinventory>>> GetEmployees()
        {
            return await _context.Mastercardinventories.ToListAsync();
        }

        // GET: api/Employees/CheckEmployeeByCardno/{empcode}
        [HttpGet("CheckEmployeeByCardno/{cardno}")]
        public async Task<IActionResult> CheckEmployeeByCardno(string cardno)
        {
            var exists = await _context.Mastercardinventories.AnyAsync(e => e.Cardno == cardno);
            return Ok(new { exists });
        }


/*        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployees(int id, [FromBody] Employee des)
        {
            if (id != des.Srno)
            {
                return BadRequest();
            }

            var existingEmployee = await _context.Employees.FindAsync(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(des.Compid))
            {
                existingEmployee.Compid = des.Compid;
            }
            if (!string.IsNullOrEmpty(des.Locationid))
            {
                existingEmployee.Locationid = des.Locationid;
            }
            if (!string.IsNullOrEmpty(des.DeptName))
            {
                existingEmployee.DeptName = des.DeptName;
            }
            if (!string.IsNullOrEmpty(des.Status))
            {
                existingEmployee.Status = des.Status;
            }
            if (!string.IsNullOrEmpty(des.Designation))
            {
                existingEmployee.Designation = des.Designation;
            }
            if (!string.IsNullOrEmpty(des.Section))
            {
                existingEmployee.Section = des.Section;
            }

            _context.Entry(existingEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesExists(id))
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
*/


        // PUT: api/Employees/UpdateEmployee/{id}

        [HttpPut("UpdateEmployee/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Mastercardinventory des)
        {
            if (id != des.Cardid)
            {
                return BadRequest(new { message = "Employee ID mismatch" });
            }

            var existingEmployee = await _context.Mastercardinventories.FindAsync(id);
            if (existingEmployee == null)
            {
                return NotFound(new { message = "Employee not found" });
            }

            existingEmployee.Cardno = des.Cardno;
            existingEmployee.Cardformat = des.Cardformat;
            existingEmployee.Status = des.Status;

            _context.Entry(existingEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesExists(id))
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


        private bool EmployeesExists(int id)
        {
            return _context.Mastercardinventories.Any(e => e.Cardid == id);
        }
    }
}
