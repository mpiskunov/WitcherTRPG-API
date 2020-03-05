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
    public class CharacterEffectsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterEffectsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterEffect>>> GetCharacterEffects()
        {
            return await _context.CharacterEffects.ToListAsync();
        }

        // GET: api/CharacterEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterEffect>> GetCharacterEffect(int id)
        {
            var characterEffect = await _context.CharacterEffects.FindAsync(id);

            if (characterEffect == null)
            {
                return NotFound();
            }

            return characterEffect;
        }

        // PUT: api/CharacterEffects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterEffect(int id, CharacterEffect characterEffect)
        {
            if (id != characterEffect.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterEffectExists(id))
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

        // POST: api/CharacterEffects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterEffect>> PostCharacterEffect(CharacterEffect characterEffect)
        {
            _context.CharacterEffects.Add(characterEffect);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterEffect", new { id = characterEffect.ID }, characterEffect);
        }

        // DELETE: api/CharacterEffects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterEffect>> DeleteCharacterEffect(int id)
        {
            var characterEffect = await _context.CharacterEffects.FindAsync(id);
            if (characterEffect == null)
            {
                return NotFound();
            }

            _context.CharacterEffects.Remove(characterEffect);
            await _context.SaveChangesAsync();

            return characterEffect;
        }

        private bool CharacterEffectExists(int id)
        {
            return _context.CharacterEffects.Any(e => e.ID == id);
        }
    }
}
