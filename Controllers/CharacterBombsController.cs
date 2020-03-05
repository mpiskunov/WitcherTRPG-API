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
    public class CharacterBombsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterBombsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterBombs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterBomb>>> GetCharacterBombs()
        {
            return await _context.CharacterBombs.ToListAsync();
        }

        // GET: api/CharacterBombs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterBomb>> GetCharacterBomb(int id)
        {
            var characterBomb = await _context.CharacterBombs.FindAsync(id);

            if (characterBomb == null)
            {
                return NotFound();
            }

            return characterBomb;
        }

        // PUT: api/CharacterBombs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterBomb(int id, CharacterBomb characterBomb)
        {
            if (id != characterBomb.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterBomb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterBombExists(id))
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

        // POST: api/CharacterBombs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterBomb>> PostCharacterBomb(CharacterBomb characterBomb)
        {
            _context.CharacterBombs.Add(characterBomb);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterBombExists(characterBomb.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterBomb", new { id = characterBomb.CharacterSheetID }, characterBomb);
        }

        // DELETE: api/CharacterBombs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterBomb>> DeleteCharacterBomb(int id)
        {
            var characterBomb = await _context.CharacterBombs.FindAsync(id);
            if (characterBomb == null)
            {
                return NotFound();
            }

            _context.CharacterBombs.Remove(characterBomb);
            await _context.SaveChangesAsync();

            return characterBomb;
        }

        private bool CharacterBombExists(int id)
        {
            return _context.CharacterBombs.Any(e => e.CharacterSheetID == id);
        }
    }
}
