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
    public class CharacterRunesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterRunesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterRunes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterRune>>> GetCharacterRunes()
        {
            return await _context.CharacterRunes.ToListAsync();
        }

        // GET: api/CharacterRunes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterRune>> GetCharacterRune(int id)
        {
            var characterRune = await _context.CharacterRunes.FindAsync(id);

            if (characterRune == null)
            {
                return NotFound();
            }

            return characterRune;
        }

        // PUT: api/CharacterRunes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterRune(int id, CharacterRune characterRune)
        {
            if (id != characterRune.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterRune).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterRuneExists(id))
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

        // POST: api/CharacterRunes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterRune>> PostCharacterRune(CharacterRune characterRune)
        {
            _context.CharacterRunes.Add(characterRune);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterRune", new { id = characterRune.ID }, characterRune);
        }

        // DELETE: api/CharacterRunes/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterRune>> DeleteCharacterRune(int id)
        {
            var characterRune = await _context.CharacterRunes.FindAsync(id);
            if (characterRune == null)
            {
                return NotFound();
            }

            characterRune.Deleted = true;
            _context.CharacterRunes.Update(characterRune);
            await _context.SaveChangesAsync();

            return characterRune;
        }

        private bool CharacterRuneExists(int id)
        {
            return _context.CharacterRunes.Any(e => e.ID == id);
        }
    }
}
