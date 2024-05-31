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
    public class EmployeeController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public EmployeeController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>>GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/Employees/CheckEmployeeByEmpcode/{empcode}
        [HttpGet("CheckEmployeeByEmpcode/{empcode}")]
        public async Task<IActionResult> CheckEmployeeByEmpcode(string empcode)
        {
            var exists = await _context.Employees.AnyAsync(e => e.Empcode == empcode);
            return Ok(new { exists });
        }

        // GET: api/Employees/CheckEmployeeByEnrollno/{enrollno}
        [HttpGet("CheckEmployeeByEnrollno/{enrollno}")]
        public async Task<IActionResult> CheckEmployeeByEnrollno(long enrollno)
        {
            var exists = await _context.Employees.AnyAsync(e => e.Enrollno == enrollno);
            return Ok(new { exists });
        }



        // POST: api/Employees

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployees(Employee des)
        {
            // Check if a Employee with the same name already exists

            if (_context.Employees.Any(c => c.Fname == des.Fname))
            {
                return Conflict(new { message = $"A Employee with the name '{des.Fname}' already exists." });
            }

            var newEmployeeMaster = new Employee
            {
                Empid = des.Empid,
                Enrollno=des.Enrollno,
                Empcode = des.Empcode,
                Fname = des.Fname,
                Compid = des.Compid,
                Locationid=des.Locationid,
                DeptName = des.DeptName,
                Designation = des.Designation,
                Status = des.Status,
            };

            _context.Employees.Add(newEmployeeMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployees", new { id = newEmployeeMaster.Srno }, newEmployeeMaster);
        }

        // PUT: api/Employees/5
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

            // Update only the fields that are specified in the des object
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


        // Search: api/Employees/Search
        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<Employee>>> SearchEmployees(string empcode = "", string fname = "", string cardno = "")
        {
            var query = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(empcode))
            {
                query = query.Where(e => e.Empcode.Contains(empcode));
            }

            if (!string.IsNullOrEmpty(fname))
            {
                query = query.Where(e => e.Fname.Contains(fname));
            }

            if (!string.IsNullOrEmpty(cardno))
            {
                query = query.Where(e => e.Cardno.Contains(cardno));
            }

            return await query.ToListAsync();
        }

        // Search: api/Employee/SearchByDetails

        [HttpGet("SearchByDetails")]
        public async Task<ActionResult<IEnumerable<Employee>>> SearchEmployeesByDetails(
            string compid = "",
            string locationid = "",
            string deptname = "",
            string status = "",
            string designation = "",
            string section = "" )
        {
            var query = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(compid))
            {
                query = query.Where(e => e.Compid.Contains(compid));
            }

            if (!string.IsNullOrEmpty(locationid))
            {
                query = query.Where(e => e.Locationid.Contains(locationid));
            }

            if (!string.IsNullOrEmpty(deptname))
            {
                query = query.Where(e => e.DeptName.Contains(deptname));
            }

            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(e => e.Status.Contains(status));
            }

            if (!string.IsNullOrEmpty(designation))
            {
                query = query.Where(e => e.Designation.Contains(designation));
            }

            if (!string.IsNullOrEmpty(section))
            {
                query = query.Where(e => e.Section.Contains(section));
            }

            return await query.ToListAsync();
            
        }



        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployees(int id)
        {
            var dp = await _context.Employees.FindAsync(id);
            if (dp == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(dp);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.Srno == id);
        }
    }
}
