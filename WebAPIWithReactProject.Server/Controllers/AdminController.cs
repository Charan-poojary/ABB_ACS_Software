using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIWithReactProject.Server.Models;
using System.Security.Cryptography;
using System.Text;

namespace WebAPIWithReactProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly BpclWarangalAuditDbContext _context;

        public AdminController(BpclWarangalAuditDbContext context)
        {
            _context = context;
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdminTables()
        {
            return await _context.Admins.ToListAsync();
        }



        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdminTable(int id)
        {
            var adminTable = await _context.Admins.FindAsync(id);

            if (adminTable == null)
            {
                return NotFound();
            }

            return adminTable;
        }


        [HttpGet("check-username")]
        public async Task<IActionResult> CheckUsername(string username)
        {
            var exists = await _context.Admins.AnyAsync(a => a.Uname == username);

            if (exists)
            {
                return Ok(new { exists = true });
            }

            return Ok(new { exists = false });
        }



        // GET : api/Admin/by-credentials?usernameOrEmail=ram&password=1234

        [HttpGet("by-credentials")]
        public async Task<ActionResult<Admin>> GetAdminByCredentials(string usernameOrEmail, string password)
        {
            string hashedPassword = HashPassword(password);

            var adminTable = await _context.Admins.FirstOrDefaultAsync(a =>
                (a.Uname == usernameOrEmail || a.Email == usernameOrEmail) && a.Pass == hashedPassword);

            if (adminTable == null)
            {
                return NotFound();
            }

            return adminTable;
        }

        //GET :api/Admin/forgot-password?email=abc@gmail.com

        [HttpGet("forgot-password")]
        public async Task<ActionResult<Admin>> ForgotPassword(string email)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Email == email);

            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin.Uname);
        }

        // GET :api/Admin/get-email?username=adminUser

        [HttpGet("get-email")]
        public async Task<ActionResult<Admin>> GetEmail(string username)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Uname == username);

            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin.Email);
        }

        //PUT: 

        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword(string username, string password)
        {
            var user = await _context.Admins.FirstOrDefaultAsync(a => a.Uname == username);

            if (user == null)
            {
                return NotFound();
            }

            user.Pass = HashPassword(password);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminTable(int id, Admin adminTable)
        {
            if (id != adminTable.Srno)
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
        public async Task<ActionResult<Admin>> PostAdminTable(Admin adminTable)
        {
            adminTable.Pass = HashPassword(adminTable.Pass);
            _context.Admins.Add(adminTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminTables", new { id = adminTable.Srno }, adminTable);
        }


        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminTable(int id)
        {
            var adminTable = await _context.Admins.FindAsync(id);
            if (adminTable == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(adminTable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminTableExists(int id)
        {
            return _context.Admins.Any(e => e.Srno == id);
        }

        // Helper method to hash passwords using bcrypt
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
