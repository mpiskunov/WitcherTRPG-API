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
    public class CharacterWeaponEffectsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterWeaponEffectsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterWeaponEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterWeaponEffect>>> GetCharacterWeaponEffects()
        {
            return await _context.CharacterWeaponEffects.ToListAsync();
        }

        // GET: api/CharacterWeaponEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterWeaponEffect>> GetCharacterWeaponEffect(int id)
        {
            var characterWeaponEffect = await _context.CharacterWeaponEffects.FindAsync(id);

            if (characterWeaponEffect == null)
            {
                return NotFound();
            }

            return characterWeaponEffect;
        }

        // PUT: api/CharacterWeaponEffects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterWeaponEffect(int id, CharacterWeaponEffect characterWeaponEffect)
        {
            if (id != characterWeaponEffect.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterWeaponEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterWeaponEffectExists(id))
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

        // POST: api/CharacterWeaponEffects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterWeaponEffect>> PostCharacterWeaponEffect(CharacterWeaponEffect characterWeaponEffect)
        {
            _context.CharacterWeaponEffects.Add(characterWeaponEffect);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterWeaponEffect", new { id = characterWeaponEffect.ID }, characterWeaponEffect);
        }

        // DELETE: api/CharacterWeaponEffects/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterWeaponEffect>> DeleteCharacterWeaponEffect(int id)
        {
            var characterWeaponEffect = await _context.CharacterWeaponEffects.FindAsync(id);
            if (characterWeaponEffect == null)
            {
                return NotFound();
            }

            characterWeaponEffect.Deleted = true;
            _context.CharacterWeaponEffects.Update(characterWeaponEffect);
            await _context.SaveChangesAsync();

            return characterWeaponEffect;
        }

        private bool CharacterWeaponEffectExists(int id)
        {
            return _context.CharacterWeaponEffects.Any(e => e.ID == id);
        }
    }
}
