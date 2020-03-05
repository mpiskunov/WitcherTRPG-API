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
    public class ArmorEffectsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public ArmorEffectsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/ArmorEffects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmorEffect>>> GetArmorEffects()
        {
            return await _context.ArmorEffects.ToListAsync();
        }

        // GET: api/ArmorEffects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArmorEffect>> GetArmorEffect(int id)
        {
            var armorEffect = await _context.ArmorEffects.FindAsync(id);

            if (armorEffect == null)
            {
                return NotFound();
            }

            return armorEffect;
        }

        // PUT: api/ArmorEffects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmorEffect(int id, ArmorEffect armorEffect)
        {
            if (id != armorEffect.ArmorID)
            {
                return BadRequest();
            }

            _context.Entry(armorEffect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmorEffectExists(id))
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

        // POST: api/ArmorEffects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ArmorEffect>> PostArmorEffect(ArmorEffect armorEffect)
        {
            _context.ArmorEffects.Add(armorEffect);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ArmorEffectExists(armorEffect.ArmorID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetArmorEffect", new { id = armorEffect.ArmorID }, armorEffect);
        }

        // DELETE: api/ArmorEffects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ArmorEffect>> DeleteArmorEffect(int id)
        {
            var armorEffect = await _context.ArmorEffects.FindAsync(id);
            if (armorEffect == null)
            {
                return NotFound();
            }

            _context.ArmorEffects.Remove(armorEffect);
            await _context.SaveChangesAsync();

            return armorEffect;
        }

        private bool ArmorEffectExists(int id)
        {
            return _context.ArmorEffects.Any(e => e.ArmorID == id);
        }
    }
}
