using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPGWebApplication.Data;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrapsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public TrapsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Traps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trap>>> GetTraps()
        {
            return await _context.Traps.ToListAsync();
        }

        // GET: api/Traps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trap>> GetTrap(int id)
        {
            var trap = await _context.Traps.FindAsync(id);

            if (trap == null)
            {
                return NotFound();
            }

            return trap;
        }

        // PUT: api/Traps/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrap(int id, Trap trap)
        {
            if (id != trap.ID)
            {
                return BadRequest();
            }

            _context.Entry(trap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrapExists(id))
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

        // POST: api/Traps
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Trap>> PostTrap(Trap trap)
        {
            _context.Traps.Add(trap);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrap", new { id = trap.ID }, trap);
        }

        // DELETE: api/Traps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trap>> DeleteTrap(int id)
        {
            var trap = await _context.Traps.FindAsync(id);
            if (trap == null)
            {
                return NotFound();
            }

            _context.Traps.Remove(trap);
            await _context.SaveChangesAsync();

            return trap;
        }

        private bool TrapExists(int id)
        {
            return _context.Traps.Any(e => e.ID == id);
        }
    }
}
