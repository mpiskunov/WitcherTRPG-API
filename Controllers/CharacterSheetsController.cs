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
    public class CharacterSheetsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterSheetsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSheets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSheet>>> GetCharacterSheets()
        {
            return await _context.CharacterSheets.ToListAsync();
        }

        // GET: api/CharacterSheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSheet>> GetCharacterSheet(int id)
        {
            var characterSheet = await _context.CharacterSheets.FindAsync(id);

            if (characterSheet == null)
            {
                return NotFound();
            }

            return characterSheet;
        }

        // PUT: api/CharacterSheets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterSheet(int id, CharacterSheet characterSheet)
        {
            if (id != characterSheet.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterSheetExists(id))
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

        // POST: api/CharacterSheets
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterSheet>> PostCharacterSheet(CharacterSheet characterSheet)
        {
            _context.CharacterSheets.Add(characterSheet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterSheet", new { id = characterSheet.CharacterSheetID }, characterSheet);
        }

        // DELETE: api/CharacterSheets/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterSheet>> DeleteCharacterSheet(int id)
        {
            var characterSheet = await _context.CharacterSheets.FindAsync(id);
            if (characterSheet == null)
            {
                return NotFound();
            }

            characterSheet.Deleted = true;
            _context.CharacterSheets.Update(characterSheet);
            await _context.SaveChangesAsync();

            return characterSheet;
        }

        private bool CharacterSheetExists(int id)
        {
            return _context.CharacterSheets.Any(e => e.CharacterSheetID == id);
        }
    }
}
