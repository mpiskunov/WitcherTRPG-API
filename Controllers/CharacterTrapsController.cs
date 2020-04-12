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
    public class CharacterTrapsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterTrapsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterTraps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterTrap>>> GetCharacterTraps()
        {
            return await _context.CharacterTraps.ToListAsync();
        }

        // GET: api/CharacterTraps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterTrap>> GetCharacterTrap(int id)
        {
            var characterTrap = await _context.CharacterTraps.FindAsync(id);

            if (characterTrap == null)
            {
                return NotFound();
            }

            return characterTrap;
        }

        // PUT: api/CharacterTraps/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterTrap(int id, CharacterTrap characterTrap)
        {
            if (id != characterTrap.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterTrap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterTrapExists(id))
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

        // POST: api/CharacterTraps
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterTrap>> PostCharacterTrap(CharacterTrap characterTrap)
        {
            _context.CharacterTraps.Add(characterTrap);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterTrapExists(characterTrap.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterTrap", new { id = characterTrap.CharacterSheetID }, characterTrap);
        }

        // DELETE: api/CharacterTraps/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterTrap>> DeleteCharacterTrap(int id)
        {
            var characterTrap = await _context.CharacterTraps.FindAsync(id);
            if (characterTrap == null)
            {
                return NotFound();
            }

            characterTrap.Deleted = true;
            _context.CharacterTraps.Update(characterTrap);
            await _context.SaveChangesAsync();

            return characterTrap;
        }

        private bool CharacterTrapExists(int id)
        {
            return _context.CharacterTraps.Any(e => e.CharacterSheetID == id);
        }
    }
}
