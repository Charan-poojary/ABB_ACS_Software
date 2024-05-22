using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIWithReactProject.Server.Models;

namespace WebAPIWithReactProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminDbContext _context;

        public AdminController()
        {
            _context = new AdminDbContext();
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminTable>>> GetAdminTables()
        {
            return await _context.AdminTables.ToListAsync();
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminTable>> GetAdminTable(int id)
        {
            var adminTable = await _context.AdminTables.FindAsync(id);

            if (adminTable == null)
            {
                return NotFound();
            }

            return adminTable;
        }

        // GET : api/Admin/by-credentials?usernameOrEmail=ram&password=1234

        [HttpGet("by-credentials")]
        public async Task<ActionResult<AdminTable>> GetAdminByCredentials(string usernameOrEmail, string password)
        {
            var adminTable = await _context.AdminTables.FirstOrDefaultAsync(a =>
                (a.AdminName == usernameOrEmail || a.AdminEmail == usernameOrEmail) && a.AdminPassword == password);

            if (adminTable == null)
            {
                return NotFound();
            }

            return adminTable;
        }

        //GET :api/Admin/forgot-password?email=abc@gmail.com

        [HttpGet("forgot-password")]
        public async Task<ActionResult<AdminTable>> ForgotPassword(string email)
        {
            var admin = await _context.AdminTables.FirstOrDefaultAsync(a => a.AdminEmail == email);

            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin.AdminName);
        }

        // GET :api/Admin/get-email?username=adminUser

        [HttpGet("get-email")]
        public async Task<ActionResult<AdminTable>> GetEmail(string username)
        {
            var admin = await _context.AdminTables.FirstOrDefaultAsync(a => a.AdminName == username);

            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin.AdminEmail);
        }

        //PUT: 

        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword(string username, string password)
        {
            var user = await _context.AdminTables.FirstOrDefaultAsync(a => a.AdminName == username);

            if (user == null)
            {
                return NotFound();
            }

            user.AdminPassword = password;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminTable(int id, AdminTable adminTable)
        {
            if (id != adminTable.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(adminTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminTableExists(id))
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

        // POST:api/Admin

        [HttpPost]
        public async Task<ActionResult<AdminTable>> PostAdminTable(AdminTable adminTable)
        {
            _context.AdminTables.Add(adminTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminTables", new { id = adminTable.AdminId }, adminTable);
        }


        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminTable(int id)
        {
            var adminTable = await _context.AdminTables.FindAsync(id);
            if (adminTable == null)
            {
                return NotFound();
            }

            _context.AdminTables.Remove(adminTable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminTableExists(int id)
        {
            return _context.AdminTables.Any(e => e.AdminId == id);
        }
    }
}
