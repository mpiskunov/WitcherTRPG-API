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
    public class LightLevelModifiersController : ControllerBase
    {
        private readonly WitcherContext _context;

        public LightLevelModifiersController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/LightLevelModifiers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LightLevelModifier>>> GetLightLevelModifiers()
        {
            return await _context.LightLevelModifiers.ToListAsync();
        }

        // GET: api/LightLevelModifiers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LightLevelModifier>> GetLightLevelModifier(int id)
        {
            var lightLevelModifier = await _context.LightLevelModifiers.FindAsync(id);

            if (lightLevelModifier == null)
            {
                return NotFound();
            }

            return lightLevelModifier;
        }

        // PUT: api/LightLevelModifiers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLightLevelModifier(int id, LightLevelModifier lightLevelModifier)
        {
            if (id != lightLevelModifier.ID)
            {
                return BadRequest();
            }

            _context.Entry(lightLevelModifier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LightLevelModifierExists(id))
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

        // POST: api/LightLevelModifiers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LightLevelModifier>> PostLightLevelModifier(LightLevelModifier lightLevelModifier)
        {
            _context.LightLevelModifiers.Add(lightLevelModifier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLightLevelModifier", new { id = lightLevelModifier.ID }, lightLevelModifier);
        }

        // DELETE: api/LightLevelModifiers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LightLevelModifier>> DeleteLightLevelModifier(int id)
        {
            var lightLevelModifier = await _context.LightLevelModifiers.FindAsync(id);
            if (lightLevelModifier == null)
            {
                return NotFound();
            }

            _context.LightLevelModifiers.Remove(lightLevelModifier);
            await _context.SaveChangesAsync();

            return lightLevelModifier;
        }

        private bool LightLevelModifierExists(int id)
        {
            return _context.LightLevelModifiers.Any(e => e.ID == id);
        }
    }
}
