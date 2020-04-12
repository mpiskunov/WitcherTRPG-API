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
    public class CharacterCampaignNotesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterCampaignNotesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterCampaignNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterCampaignNote>>> GetCharacterCampaignNotes()
        {
            return await _context.CharacterCampaignNotes.ToListAsync();
        }

        // GET: api/CharacterCampaignNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterCampaignNote>> GetCharacterCampaignNote(int id)
        {
            var characterCampaignNote = await _context.CharacterCampaignNotes.FindAsync(id);

            if (characterCampaignNote == null)
            {
                return NotFound();
            }

            return characterCampaignNote;
        }

        // PUT: api/CharacterCampaignNotes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterCampaignNote(int id, CharacterCampaignNote characterCampaignNote)
        {
            if (id != characterCampaignNote.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterCampaignNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterCampaignNoteExists(id))
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

        // POST: api/CharacterCampaignNotes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterCampaignNote>> PostCharacterCampaignNote(CharacterCampaignNote characterCampaignNote)
        {
            _context.CharacterCampaignNotes.Add(characterCampaignNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterCampaignNote", new { id = characterCampaignNote.ID }, characterCampaignNote);
        }

        // DELETE: api/CharacterCampaignNotes/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterCampaignNote>> DeleteCharacterCampaignNote(int id)
        {
            var characterCampaignNote = await _context.CharacterCampaignNotes.FindAsync(id);
            if (characterCampaignNote == null)
            {
                return NotFound();
            }

            characterCampaignNote.Deleted = true;
            _context.CharacterCampaignNotes.Update(characterCampaignNote);
            await _context.SaveChangesAsync();

            return characterCampaignNote;
        }

        private bool CharacterCampaignNoteExists(int id)
        {
            return _context.CharacterCampaignNotes.Any(e => e.ID == id);
        }
    }
}
