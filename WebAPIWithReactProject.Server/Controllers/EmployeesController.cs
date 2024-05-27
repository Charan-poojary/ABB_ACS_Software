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


        // POST: api/EmployeeCategory/CheckEmployeeCategory/{}

/*        [HttpGet("CheckEmployeeCategory/{catname}")]
        public async Task<IActionResult> CheckEmployeeCategory(string catname)
        {
            var exists = await _context.EmpCatMasters.AnyAsync(cm => cm.Catname == catname);
            return Ok(new { exists });
        }*/


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
                Empcode = des.Empcode,
                Fname = des.Fname,
                Cardno = des.Cardno,
                Pin=des.Pin,

            };

            _context.Employees.Add(newEmployeeMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployees", new { id = newEmployeeMaster.Srno }, newEmployeeMaster);
        }

        // PUT: api/Employees/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployees(int id, Employee des)
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



        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.Srno == id);
        }
    }
}
