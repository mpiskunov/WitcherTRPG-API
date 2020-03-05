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
    public class CharacterToolKitsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterToolKitsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterToolKits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterToolKit>>> GetCharacterToolKits()
        {
            return await _context.CharacterToolKits.ToListAsync();
        }

        // GET: api/CharacterToolKits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterToolKit>> GetCharacterToolKit(int id)
        {
            var characterToolKit = await _context.CharacterToolKits.FindAsync(id);

            if (characterToolKit == null)
            {
                return NotFound();
            }

            return characterToolKit;
        }

        // PUT: api/CharacterToolKits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterToolKit(int id, CharacterToolKit characterToolKit)
        {
            if (id != characterToolKit.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterToolKit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterToolKitExists(id))
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

        // POST: api/CharacterToolKits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterToolKit>> PostCharacterToolKit(CharacterToolKit characterToolKit)
        {
            _context.CharacterToolKits.Add(characterToolKit);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterToolKitExists(characterToolKit.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterToolKit", new { id = characterToolKit.CharacterSheetID }, characterToolKit);
        }

        // DELETE: api/CharacterToolKits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterToolKit>> DeleteCharacterToolKit(int id)
        {
            var characterToolKit = await _context.CharacterToolKits.FindAsync(id);
            if (characterToolKit == null)
            {
                return NotFound();
            }

            _context.CharacterToolKits.Remove(characterToolKit);
            await _context.SaveChangesAsync();

            return characterToolKit;
        }

        private bool CharacterToolKitExists(int id)
        {
            return _context.CharacterToolKits.Any(e => e.CharacterSheetID == id);
        }
    }
}
