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
    public class RacialPerksController : ControllerBase
    {
        private readonly WitcherContext _context;

        public RacialPerksController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/RacialPerks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RacialPerk>>> GetRacialPerks()
        {
            return await _context.RacialPerks.ToListAsync();
        }

        // GET: api/RacialPerks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RacialPerk>> GetRacialPerk(int id)
        {
            var racialPerk = await _context.RacialPerks.FindAsync(id);

            if (racialPerk == null)
            {
                return NotFound();
            }

            return racialPerk;
        }

        // PUT: api/RacialPerks/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRacialPerk(int id, RacialPerk racialPerk)
        {
            if (id != racialPerk.ID)
            {
                return BadRequest();
            }

            _context.Entry(racialPerk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacialPerkExists(id))
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

        // POST: api/RacialPerks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RacialPerk>> PostRacialPerk(RacialPerk racialPerk)
        {
            _context.RacialPerks.Add(racialPerk);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRacialPerk", new { id = racialPerk.ID }, racialPerk);
        }

        // DELETE: api/RacialPerks/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<RacialPerk>> DeleteRacialPerk(int id)
        {
            var racialPerk = await _context.RacialPerks.FindAsync(id);
            if (racialPerk == null)
            {
                return NotFound();
            }

            racialPerk.Deleted = true;
            _context.RacialPerks.Update(racialPerk);
            await _context.SaveChangesAsync();

            return racialPerk;
        }

        private bool RacialPerkExists(int id)
        {
            return _context.RacialPerks.Any(e => e.ID == id);
        }
    }
}
