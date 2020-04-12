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
    public class ArmorEnhancementsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public ArmorEnhancementsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/ArmorEnhancements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmorEnhancement>>> GetArmorEnhancements()
        {
            return await _context.ArmorEnhancements.ToListAsync();
        }

        // GET: api/ArmorEnhancements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArmorEnhancement>> GetArmorEnhancement(int id)
        {
            var armorEnhancement = await _context.ArmorEnhancements.FindAsync(id);

            if (armorEnhancement == null)
            {
                return NotFound();
            }

            return armorEnhancement;
        }

        // PUT: api/ArmorEnhancements/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmorEnhancement(int id, ArmorEnhancement armorEnhancement)
        {
            if (id != armorEnhancement.ID)
            {
                return BadRequest();
            }

            _context.Entry(armorEnhancement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmorEnhancementExists(id))
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

        // POST: api/ArmorEnhancements
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ArmorEnhancement>> PostArmorEnhancement(ArmorEnhancement armorEnhancement)
        {
            _context.ArmorEnhancements.Add(armorEnhancement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArmorEnhancement", new { id = armorEnhancement.ID }, armorEnhancement);
        }

        // DELETE: api/ArmorEnhancements/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<ArmorEnhancement>> DeleteArmorEnhancement(int id)
        {
            var armorEnhancement = await _context.ArmorEnhancements.FindAsync(id);
            if (armorEnhancement == null)
            {
                return NotFound();
            }

            armorEnhancement.Deleted = true;
            _context.ArmorEnhancements.Update(armorEnhancement);
            await _context.SaveChangesAsync();

            return armorEnhancement;
        }

        private bool ArmorEnhancementExists(int id)
        {
            return _context.ArmorEnhancements.Any(e => e.ID == id);
        }
    }
}
