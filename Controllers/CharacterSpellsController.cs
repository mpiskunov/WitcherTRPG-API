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
    public class CharacterSpellsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterSpellsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSpells
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSpell>>> GetCharacterSpells()
        {
            return await _context.CharacterSpells.ToListAsync();
        }

        // GET: api/CharacterSpells/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSpell>> GetCharacterSpell(int id)
        {
            var characterSpell = await _context.CharacterSpells.FindAsync(id);

            if (characterSpell == null)
            {
                return NotFound();
            }

            return characterSpell;
        }

        // PUT: api/CharacterSpells/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterSpell(int id, CharacterSpell characterSpell)
        {
            if (id != characterSpell.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterSpell).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterSpellExists(id))
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

        // POST: api/CharacterSpells
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterSpell>> PostCharacterSpell(CharacterSpell characterSpell)
        {
            _context.CharacterSpells.Add(characterSpell);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterSpellExists(characterSpell.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterSpell", new { id = characterSpell.CharacterSheetID }, characterSpell);
        }

        // DELETE: api/CharacterSpells/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterSpell>> DeleteCharacterSpell(int id)
        {
            var characterSpell = await _context.CharacterSpells.FindAsync(id);
            if (characterSpell == null)
            {
                return NotFound();
            }

            _context.CharacterSpells.Remove(characterSpell);
            await _context.SaveChangesAsync();

            return characterSpell;
        }

        private bool CharacterSpellExists(int id)
        {
            return _context.CharacterSpells.Any(e => e.CharacterSheetID == id);
        }
    }
}
