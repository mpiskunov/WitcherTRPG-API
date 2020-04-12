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
    public class AmmunitionEffectsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AmmunitionEffectsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/AmmunitionEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmmunitionEffect>>> GetAmmunitionEffects()
        {
            return await _context.AmmunitionEffects.ToListAsync();
        }

        // GET: api/AmmunitionEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AmmunitionEffect>> GetAmmunitionEffect(int id)
        {
            var ammunitionEffect = await _context.AmmunitionEffects.FindAsync(id);

            if (ammunitionEffect == null)
            {
                return NotFound();
            }

            return ammunitionEffect;
        }

        // PUT: api/AmmunitionEffects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmmunitionEffect(int id, AmmunitionEffect ammunitionEffect)
        {
            if (id != ammunitionEffect.AmmunitionID)
            {
                return BadRequest();
            }

            _context.Entry(ammunitionEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmmunitionEffectExists(id))
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

        // POST: api/AmmunitionEffects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AmmunitionEffect>> PostAmmunitionEffect(AmmunitionEffect ammunitionEffect)
        {
            _context.AmmunitionEffects.Add(ammunitionEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AmmunitionEffectExists(ammunitionEffect.AmmunitionID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAmmunitionEffect", new { id = ammunitionEffect.AmmunitionID }, ammunitionEffect);
        }

        // DELETE: api/AmmunitionEffects/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<AmmunitionEffect>> DeleteAmmunitionEffect(int id)
        {
            var ammunitionEffect = await _context.AmmunitionEffects.FindAsync(id);
            if (ammunitionEffect == null)
            {
                return NotFound();
            }

            ammunitionEffect.Deleted = true;
            _context.AmmunitionEffects.Update(ammunitionEffect);
            await _context.SaveChangesAsync();

            return ammunitionEffect;
        }

        private bool AmmunitionEffectExists(int id)
        {
            return _context.AmmunitionEffects.Any(e => e.AmmunitionID == id);
        }
    }
}
