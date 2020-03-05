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
    public class CriticalLevelsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CriticalLevelsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CriticalLevels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CriticalLevel>>> GetCriticalLevels()
        {
            return await _context.CriticalLevels.ToListAsync();
        }

        // GET: api/CriticalLevels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CriticalLevel>> GetCriticalLevel(int id)
        {
            var criticalLevel = await _context.CriticalLevels.FindAsync(id);

            if (criticalLevel == null)
            {
                return NotFound();
            }

            return criticalLevel;
        }

        // PUT: api/CriticalLevels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCriticalLevel(int id, CriticalLevel criticalLevel)
        {
            if (id != criticalLevel.ID)
            {
                return BadRequest();
            }

            _context.Entry(criticalLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriticalLevelExists(id))
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

        // POST: api/CriticalLevels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CriticalLevel>> PostCriticalLevel(CriticalLevel criticalLevel)
        {
            _context.CriticalLevels.Add(criticalLevel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCriticalLevel", new { id = criticalLevel.ID }, criticalLevel);
        }

        // DELETE: api/CriticalLevels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CriticalLevel>> DeleteCriticalLevel(int id)
        {
            var criticalLevel = await _context.CriticalLevels.FindAsync(id);
            if (criticalLevel == null)
            {
                return NotFound();
            }

            _context.CriticalLevels.Remove(criticalLevel);
            await _context.SaveChangesAsync();

            return criticalLevel;
        }

        private bool CriticalLevelExists(int id)
        {
            return _context.CriticalLevels.Any(e => e.ID == id);
        }
    }
}
