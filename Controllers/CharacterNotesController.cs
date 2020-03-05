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
    public class CharacterNotesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterNotesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterNote>>> GetCharacterNotes()
        {
            return await _context.CharacterNotes.ToListAsync();
        }

        // GET: api/CharacterNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterNote>> GetCharacterNote(int id)
        {
            var characterNote = await _context.CharacterNotes.FindAsync(id);

            if (characterNote == null)
            {
                return NotFound();
            }

            return characterNote;
        }

        // PUT: api/CharacterNotes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterNote(int id, CharacterNote characterNote)
        {
            if (id != characterNote.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterNoteExists(id))
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

        // POST: api/CharacterNotes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterNote>> PostCharacterNote(CharacterNote characterNote)
        {
            _context.CharacterNotes.Add(characterNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterNote", new { id = characterNote.ID }, characterNote);
        }

        // DELETE: api/CharacterNotes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterNote>> DeleteCharacterNote(int id)
        {
            var characterNote = await _context.CharacterNotes.FindAsync(id);
            if (characterNote == null)
            {
                return NotFound();
            }

            _context.CharacterNotes.Remove(characterNote);
            await _context.SaveChangesAsync();

            return characterNote;
        }

        private bool CharacterNoteExists(int id)
        {
            return _context.CharacterNotes.Any(e => e.ID == id);
        }
    }
}
