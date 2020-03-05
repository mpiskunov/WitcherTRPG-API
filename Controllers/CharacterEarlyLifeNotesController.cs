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
    public class CharacterEarlyLifeNotesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterEarlyLifeNotesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterEarlyLifeNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterEarlyLifeNote>>> GetCharacterEarlyLifeNotes()
        {
            return await _context.CharacterEarlyLifeNotes.ToListAsync();
        }

        // GET: api/CharacterEarlyLifeNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterEarlyLifeNote>> GetCharacterEarlyLifeNote(int id)
        {
            var characterEarlyLifeNote = await _context.CharacterEarlyLifeNotes.FindAsync(id);

            if (characterEarlyLifeNote == null)
            {
                return NotFound();
            }

            return characterEarlyLifeNote;
        }

        // PUT: api/CharacterEarlyLifeNotes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterEarlyLifeNote(int id, CharacterEarlyLifeNote characterEarlyLifeNote)
        {
            if (id != characterEarlyLifeNote.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterEarlyLifeNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterEarlyLifeNoteExists(id))
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

        // POST: api/CharacterEarlyLifeNotes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterEarlyLifeNote>> PostCharacterEarlyLifeNote(CharacterEarlyLifeNote characterEarlyLifeNote)
        {
            _context.CharacterEarlyLifeNotes.Add(characterEarlyLifeNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterEarlyLifeNote", new { id = characterEarlyLifeNote.ID }, characterEarlyLifeNote);
        }

        // DELETE: api/CharacterEarlyLifeNotes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterEarlyLifeNote>> DeleteCharacterEarlyLifeNote(int id)
        {
            var characterEarlyLifeNote = await _context.CharacterEarlyLifeNotes.FindAsync(id);
            if (characterEarlyLifeNote == null)
            {
                return NotFound();
            }

            _context.CharacterEarlyLifeNotes.Remove(characterEarlyLifeNote);
            await _context.SaveChangesAsync();

            return characterEarlyLifeNote;
        }

        private bool CharacterEarlyLifeNoteExists(int id)
        {
            return _context.CharacterEarlyLifeNotes.Any(e => e.ID == id);
        }
    }
}
