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
    public class ArmorEnhancementPackagesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public ArmorEnhancementPackagesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/ArmorEnhancementPackages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmorEnhancementPackage>>> GetArmorEnhancementPackage()
        {
            return await _context.ArmorEnhancementPackage.ToListAsync();
        }

        // GET: api/ArmorEnhancementPackages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArmorEnhancementPackage>> GetArmorEnhancementPackage(int id)
        {
            var armorEnhancementPackage = await _context.ArmorEnhancementPackage.FindAsync(id);

            if (armorEnhancementPackage == null)
            {
                return NotFound();
            }

            return armorEnhancementPackage;
        }

        // PUT: api/ArmorEnhancementPackages/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmorEnhancementPackage(int id, ArmorEnhancementPackage armorEnhancementPackage)
        {
            if (id != armorEnhancementPackage.ID)
            {
                return BadRequest();
            }

            _context.Entry(armorEnhancementPackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmorEnhancementPackageExists(id))
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

        // POST: api/ArmorEnhancementPackages
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ArmorEnhancementPackage>> PostArmorEnhancementPackage(ArmorEnhancementPackage armorEnhancementPackage)
        {
            _context.ArmorEnhancementPackage.Add(armorEnhancementPackage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArmorEnhancementPackage", new { id = armorEnhancementPackage.ID }, armorEnhancementPackage);
        }

        // DELETE: api/ArmorEnhancementPackages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ArmorEnhancementPackage>> DeleteArmorEnhancementPackage(int id)
        {
            var armorEnhancementPackage = await _context.ArmorEnhancementPackage.FindAsync(id);
            if (armorEnhancementPackage == null)
            {
                return NotFound();
            }

            _context.ArmorEnhancementPackage.Remove(armorEnhancementPackage);
            await _context.SaveChangesAsync();

            return armorEnhancementPackage;
        }

        private bool ArmorEnhancementPackageExists(int id)
        {
            return _context.ArmorEnhancementPackage.Any(e => e.ID == id);
        }
    }
}
