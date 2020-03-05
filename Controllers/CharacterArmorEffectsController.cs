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
    public class CharacterArmorEffectsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterArmorEffectsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterArmorEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterArmorEffect>>> GetCharacterArmorEffects()
        {
            return await _context.CharacterArmorEffects.ToListAsync();
        }

        // GET: api/CharacterArmorEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterArmorEffect>> GetCharacterArmorEffect(int id)
        {
            var characterArmorEffect = await _context.CharacterArmorEffects.FindAsync(id);

            if (characterArmorEffect == null)
            {
                return NotFound();
            }

            return characterArmorEffect;
        }

        // PUT: api/CharacterArmorEffects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterArmorEffect(int id, CharacterArmorEffect characterArmorEffect)
        {
            if (id != characterArmorEffect.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterArmorEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterArmorEffectExists(id))
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

        // POST: api/CharacterArmorEffects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterArmorEffect>> PostCharacterArmorEffect(CharacterArmorEffect characterArmorEffect)
        {
            _context.CharacterArmorEffects.Add(characterArmorEffect);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterArmorEffect", new { id = characterArmorEffect.ID }, characterArmorEffect);
        }

        // DELETE: api/CharacterArmorEffects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterArmorEffect>> DeleteCharacterArmorEffect(int id)
        {
            var characterArmorEffect = await _context.CharacterArmorEffects.FindAsync(id);
            if (characterArmorEffect == null)
            {
                return NotFound();
            }

            _context.CharacterArmorEffects.Remove(characterArmorEffect);
            await _context.SaveChangesAsync();

            return characterArmorEffect;
        }

        private bool CharacterArmorEffectExists(int id)
        {
            return _context.CharacterArmorEffects.Any(e => e.ID == id);
        }
    }
}
