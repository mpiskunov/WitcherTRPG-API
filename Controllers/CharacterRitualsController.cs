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
    public class CharacterRitualsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterRitualsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterRituals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterRitual>>> GetCharacterRituals()
        {
            return await _context.CharacterRituals.ToListAsync();
        }

        // GET: api/CharacterRituals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterRitual>> GetCharacterRitual(int id)
        {
            var characterRitual = await _context.CharacterRituals.FindAsync(id);

            if (characterRitual == null)
            {
                return NotFound();
            }

            return characterRitual;
        }

        // PUT: api/CharacterRituals/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterRitual(int id, CharacterRitual characterRitual)
        {
            if (id != characterRitual.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterRitual).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterRitualExists(id))
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

        // POST: api/CharacterRituals
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterRitual>> PostCharacterRitual(CharacterRitual characterRitual)
        {
            _context.CharacterRituals.Add(characterRitual);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterRitualExists(characterRitual.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterRitual", new { id = characterRitual.CharacterSheetID }, characterRitual);
        }

        // DELETE: api/CharacterRituals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterRitual>> DeleteCharacterRitual(int id)
        {
            var characterRitual = await _context.CharacterRituals.FindAsync(id);
            if (characterRitual == null)
            {
                return NotFound();
            }

            _context.CharacterRituals.Remove(characterRitual);
            await _context.SaveChangesAsync();

            return characterRitual;
        }

        private bool CharacterRitualExists(int id)
        {
            return _context.CharacterRituals.Any(e => e.CharacterSheetID == id);
        }
    }
}
