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
    public class RitualsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public RitualsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Rituals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ritual>>> GetRituals()
        {
            return await _context.Rituals.ToListAsync();
        }

        // GET: api/Rituals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ritual>> GetRitual(int id)
        {
            var ritual = await _context.Rituals.FindAsync(id);

            if (ritual == null)
            {
                return NotFound();
            }

            return ritual;
        }

        // PUT: api/Rituals/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRitual(int id, Ritual ritual)
        {
            if (id != ritual.ID)
            {
                return BadRequest();
            }

            _context.Entry(ritual).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RitualExists(id))
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

        // POST: api/Rituals
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Ritual>> PostRitual(Ritual ritual)
        {
            _context.Rituals.Add(ritual);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRitual", new { id = ritual.ID }, ritual);
        }

        // DELETE: api/Rituals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ritual>> DeleteRitual(int id)
        {
            var ritual = await _context.Rituals.FindAsync(id);
            if (ritual == null)
            {
                return NotFound();
            }

            _context.Rituals.Remove(ritual);
            await _context.SaveChangesAsync();

            return ritual;
        }

        private bool RitualExists(int id)
        {
            return _context.Rituals.Any(e => e.ID == id);
        }
    }
}
