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
    public class CharacterHexesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterHexesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterHexes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterHex>>> GetCharacterHexs()
        {
            return await _context.CharacterHexs.ToListAsync();
        }

        // GET: api/CharacterHexes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterHex>> GetCharacterHex(int id)
        {
            var characterHex = await _context.CharacterHexs.FindAsync(id);

            if (characterHex == null)
            {
                return NotFound();
            }

            return characterHex;
        }

        // PUT: api/CharacterHexes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterHex(int id, CharacterHex characterHex)
        {
            if (id != characterHex.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterHex).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterHexExists(id))
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

        // POST: api/CharacterHexes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterHex>> PostCharacterHex(CharacterHex characterHex)
        {
            _context.CharacterHexs.Add(characterHex);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterHexExists(characterHex.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterHex", new { id = characterHex.CharacterSheetID }, characterHex);
        }

        // DELETE: api/CharacterHexes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterHex>> DeleteCharacterHex(int id)
        {
            var characterHex = await _context.CharacterHexs.FindAsync(id);
            if (characterHex == null)
            {
                return NotFound();
            }

            _context.CharacterHexs.Remove(characterHex);
            await _context.SaveChangesAsync();

            return characterHex;
        }

        private bool CharacterHexExists(int id)
        {
            return _context.CharacterHexs.Any(e => e.CharacterSheetID == id);
        }
    }
}
