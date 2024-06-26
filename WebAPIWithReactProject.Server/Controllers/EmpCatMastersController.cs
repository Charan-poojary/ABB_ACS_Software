﻿using System;
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
    public class EmployeeCategoryController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public EmployeeCategoryController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeCategory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpCatMaster>>> GetEmployeeCategory()
        {
            return await _context.EmpCatMasters.ToListAsync();
        }


        // POST: api/EmployeeCategory/CheckEmployeeCategory/{}

        [HttpGet("CheckEmployeeCategory/{catname}")]
        public async Task<IActionResult> CheckEmployeeCategory(string catname)
        {
            var exists = await _context.EmpCatMasters.AnyAsync(cm => cm.Catname == catname);
            return Ok(new { exists });
        }


        // POST: api/EmployeeCategory

        [HttpPost]
        public async Task<ActionResult<EmpCatMaster>> PostEmployeeCategory(EmpCatMaster des)
        {
            // Check if a Category with the same name already exists

            if (_context.EmpCatMasters.Any(c => c.Catname == des.Catname))
            {
                return Conflict(new { message = $"A location with the name '{des.Catname}' already exists." });
            }

            var newEmployeeCategoryMaster = new EmpCatMaster
            {
                Catname = des.Catname,

            };

            _context.EmpCatMasters.Add(newEmployeeCategoryMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeCategory", new { id = newEmployeeCategoryMaster.Srno }, newEmployeeCategoryMaster);
        }

        // PUT: api/EmployeeCategory/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeCategory(int id, EmpCatMaster des)
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
                if (!EmployeeCategoryExists(id))
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

        // DELETE: api/EmployeeCategory/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeCategory(int id)
        {
            var cat = await _context.EmpCatMasters.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.EmpCatMasters.Remove(cat);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool EmployeeCategoryExists(int id)
        {
            return _context.EmpCatMasters.Any(e => e.Srno == id);
        }
    }
}
