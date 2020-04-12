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
    public class CharacterAmmunitionsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterAmmunitionsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterAmmunitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterAmmunition>>> GetCharacterAmmunitions()
        {
            return await _context.CharacterAmmunitions.ToListAsync();
        }

        // GET: api/CharacterAmmunitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterAmmunition>> GetCharacterAmmunition(int id)
        {
            var characterAmmunition = await _context.CharacterAmmunitions.FindAsync(id);

            if (characterAmmunition == null)
            {
                return NotFound();
            }

            return characterAmmunition;
        }

        // PUT: api/CharacterAmmunitions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterAmmunition(int id, CharacterAmmunition characterAmmunition)
        {
            if (id != characterAmmunition.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterAmmunition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterAmmunitionExists(id))
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

        // POST: api/CharacterAmmunitions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterAmmunition>> PostCharacterAmmunition(CharacterAmmunition characterAmmunition)
        {
            _context.CharacterAmmunitions.Add(characterAmmunition);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterAmmunitionExists(characterAmmunition.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterAmmunition", new { id = characterAmmunition.CharacterSheetID }, characterAmmunition);
        }

        // DELETE: api/CharacterAmmunitions/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterAmmunition>> DeleteCharacterAmmunition(int id)
        {
            var characterAmmunition = await _context.CharacterAmmunitions.FindAsync(id);
            if (characterAmmunition == null)
            {
                return NotFound();
            }
            
            characterAmmunition.Deleted = true;
            _context.CharacterAmmunitions.Update(characterAmmunition);
            await _context.SaveChangesAsync();

            return characterAmmunition;
        }

        private bool CharacterAmmunitionExists(int id)
        {
            return _context.CharacterAmmunitions.Any(e => e.CharacterSheetID == id);
        }
    }
}
