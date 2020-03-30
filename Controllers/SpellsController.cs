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
    public class SpellsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public SpellsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Spells
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Spell>>> GetSpells()
        {
            return await _context.Spells.OrderBy(o => o.SpellDifficultyClassification).ThenBy(o => o.Name).ToListAsync();
        }

        // GET: api/Spells/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Spell>> GetSpell(int id)
        {
            var spell = await _context.Spells.FindAsync(id);

            if (spell == null)
            {
                return NotFound();
            }

            return spell;
        }

        // PUT: api/Spells/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpell(int id, Spell spell)
        {
            if (id != spell.ID)
            {
                return BadRequest();
            }

            _context.Entry(spell).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpellExists(id))
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

        // POST: api/Spells
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Spell>> PostSpell(Spell spell)
        {
            _context.Spells.Add(spell);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpell", new { id = spell.ID }, spell);
        }

        // DELETE: api/Spells/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Spell>> DeleteSpell(int id)
        {
            var spell = await _context.Spells.FindAsync(id);
            if (spell == null)
            {
                return NotFound();
            }

            _context.Spells.Remove(spell);
            await _context.SaveChangesAsync();

            return spell;
        }

        private bool SpellExists(int id)
        {
            return _context.Spells.Any(e => e.ID == id);
        }
    }
}
