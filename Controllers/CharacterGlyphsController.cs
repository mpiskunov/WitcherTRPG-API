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
    public class CharacterGlyphsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterGlyphsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterGlyphs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterGlyph>>> GetCharacterGlyphs()
        {
            return await _context.CharacterGlyphs.ToListAsync();
        }

        // GET: api/CharacterGlyphs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterGlyph>> GetCharacterGlyph(int id)
        {
            var characterGlyph = await _context.CharacterGlyphs.FindAsync(id);

            if (characterGlyph == null)
            {
                return NotFound();
            }

            return characterGlyph;
        }

        // PUT: api/CharacterGlyphs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterGlyph(int id, CharacterGlyph characterGlyph)
        {
            if (id != characterGlyph.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterGlyph).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterGlyphExists(id))
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

        // POST: api/CharacterGlyphs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterGlyph>> PostCharacterGlyph(CharacterGlyph characterGlyph)
        {
            _context.CharacterGlyphs.Add(characterGlyph);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterGlyph", new { id = characterGlyph.ID }, characterGlyph);
        }

        // DELETE: api/CharacterGlyphs/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterGlyph>> DeleteCharacterGlyph(int id)
        {
            var characterGlyph = await _context.CharacterGlyphs.FindAsync(id);
            if (characterGlyph == null)
            {
                return NotFound();
            }

            characterGlyph.Deleted = true;
            _context.CharacterGlyphs.Update(characterGlyph);
            await _context.SaveChangesAsync();

            return characterGlyph;
        }

        private bool CharacterGlyphExists(int id)
        {
            return _context.CharacterGlyphs.Any(e => e.ID == id);
        }
    }
}
