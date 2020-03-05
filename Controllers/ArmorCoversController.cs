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
    public class ArmorCoversController : ControllerBase
    {
        private readonly WitcherContext _context;

        public ArmorCoversController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/ArmorCovers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmorCover>>> GetArmorCovers()
        {
            return await _context.ArmorCovers.ToListAsync();
        }

        // GET: api/ArmorCovers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArmorCover>> GetArmorCover(int id)
        {
            var armorCover = await _context.ArmorCovers.FindAsync(id);

            if (armorCover == null)
            {
                return NotFound();
            }

            return armorCover;
        }

        // PUT: api/ArmorCovers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmorCover(int id, ArmorCover armorCover)
        {
            if (id != armorCover.ArmorID)
            {
                return BadRequest();
            }

            _context.Entry(armorCover).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmorCoverExists(id))
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

        // POST: api/ArmorCovers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ArmorCover>> PostArmorCover(ArmorCover armorCover)
        {
            _context.ArmorCovers.Add(armorCover);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ArmorCoverExists(armorCover.ArmorID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetArmorCover", new { id = armorCover.ArmorID }, armorCover);
        }

        // DELETE: api/ArmorCovers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ArmorCover>> DeleteArmorCover(int id)
        {
            var armorCover = await _context.ArmorCovers.FindAsync(id);
            if (armorCover == null)
            {
                return NotFound();
            }

            _context.ArmorCovers.Remove(armorCover);
            await _context.SaveChangesAsync();

            return armorCover;
        }

        private bool ArmorCoverExists(int id)
        {
            return _context.ArmorCovers.Any(e => e.ArmorID == id);
        }
    }
}
