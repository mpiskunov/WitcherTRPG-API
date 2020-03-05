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
    public class DamageLocationsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public DamageLocationsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/DamageLocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DamageLocation>>> GetDamageLocations()
        {
            return await _context.DamageLocations.ToListAsync();
        }

        // GET: api/DamageLocations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DamageLocation>> GetDamageLocation(int id)
        {
            var damageLocation = await _context.DamageLocations.FindAsync(id);

            if (damageLocation == null)
            {
                return NotFound();
            }

            return damageLocation;
        }

        // PUT: api/DamageLocations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDamageLocation(int id, DamageLocation damageLocation)
        {
            if (id != damageLocation.ID)
            {
                return BadRequest();
            }

            _context.Entry(damageLocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DamageLocationExists(id))
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

        // POST: api/DamageLocations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DamageLocation>> PostDamageLocation(DamageLocation damageLocation)
        {
            _context.DamageLocations.Add(damageLocation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDamageLocation", new { id = damageLocation.ID }, damageLocation);
        }

        // DELETE: api/DamageLocations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DamageLocation>> DeleteDamageLocation(int id)
        {
            var damageLocation = await _context.DamageLocations.FindAsync(id);
            if (damageLocation == null)
            {
                return NotFound();
            }

            _context.DamageLocations.Remove(damageLocation);
            await _context.SaveChangesAsync();

            return damageLocation;
        }

        private bool DamageLocationExists(int id)
        {
            return _context.DamageLocations.Any(e => e.ID == id);
        }
    }
}
