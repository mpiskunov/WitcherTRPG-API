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
    public class WeaponEffectsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public WeaponEffectsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/WeaponEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponEffect>>> GetWeaponEffects()
        {
            return await _context.WeaponEffects.ToListAsync();
        }

        // GET: api/WeaponEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WeaponEffect>> GetWeaponEffect(int id)
        {
            var weaponEffect = await _context.WeaponEffects.FindAsync(id);

            if (weaponEffect == null)
            {
                return NotFound();
            }

            return weaponEffect;
        }

        // PUT: api/WeaponEffects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeaponEffect(int id, WeaponEffect weaponEffect)
        {
            if (id != weaponEffect.WeaponID)
            {
                return BadRequest();
            }

            _context.Entry(weaponEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeaponEffectExists(id))
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

        // POST: api/WeaponEffects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WeaponEffect>> PostWeaponEffect(WeaponEffect weaponEffect)
        {
            _context.WeaponEffects.Add(weaponEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WeaponEffectExists(weaponEffect.WeaponID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetWeaponEffect", new { id = weaponEffect.WeaponID }, weaponEffect);
        }

        // DELETE: api/WeaponEffects/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<WeaponEffect>> DeleteWeaponEffect(int id)
        {
            var weaponEffect = await _context.WeaponEffects.FindAsync(id);
            if (weaponEffect == null)
            {
                return NotFound();
            }

            weaponEffect.Deleted = true;
            _context.WeaponEffects.Update(weaponEffect);
            await _context.SaveChangesAsync();

            return weaponEffect;
        }

        private bool WeaponEffectExists(int id)
        {
            return _context.WeaponEffects.Any(e => e.WeaponID == id);
        }
    }
}
