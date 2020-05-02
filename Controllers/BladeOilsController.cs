using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPGWebApplication.Data;
using WitcherTRPG_API.Models;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BladeOilsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public BladeOilsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/BladeOils
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BladeOil>>> GetBladeOils()
        {
            return await _context.BladeOils.ToListAsync();
        }

        // GET: api/BladeOils/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BladeOil>> GetBladeOil(int id)
        {
            var bladeOil = await _context.BladeOils.FindAsync(id);

            if (bladeOil == null)
            {
                return NotFound();
            }

            return bladeOil;
        }

        // PUT: api/BladeOils/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBladeOil(int id, BladeOil bladeOil)
        {
            if (id != bladeOil.ID)
            {
                return BadRequest();
            }

            _context.Entry(bladeOil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BladeOilExists(id))
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

        // POST: api/BladeOils
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BladeOil>> PostBladeOil(BladeOil bladeOil)
        {
            _context.BladeOils.Add(bladeOil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBladeOil", new { id = bladeOil.ID }, bladeOil);
        }

        // DELETE: api/BladeOils/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<BladeOil>> DeleteBladeOil(int id)
        {
            var bladeOil = await _context.BladeOils.FindAsync(id);
            if (bladeOil == null)
            {
                return NotFound();
            }

            bladeOil.Deleted = true;
            _context.BladeOils.Update(bladeOil);
            await _context.SaveChangesAsync();

            return bladeOil;
        }

        private bool BladeOilExists(int id)
        {
            return _context.BladeOils.Any(e => e.ID == id);
        }
    }
}
