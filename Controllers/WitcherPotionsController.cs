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
    public class WitcherPotionsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public WitcherPotionsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/WitcherPotions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WitcherPotion>>> GetWitcherPotions()
        {
            return await _context.WitcherPotions.ToListAsync();
        }

        // GET: api/WitcherPotions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WitcherPotion>> GetWitcherPotion(int id)
        {
            var witcherPotion = await _context.WitcherPotions.FindAsync(id);

            if (witcherPotion == null)
            {
                return NotFound();
            }

            return witcherPotion;
        }

        // PUT: api/WitcherPotions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWitcherPotion(int id, WitcherPotion witcherPotion)
        {
            if (id != witcherPotion.ID)
            {
                return BadRequest();
            }

            _context.Entry(witcherPotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WitcherPotionExists(id))
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

        // POST: api/WitcherPotions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WitcherPotion>> PostWitcherPotion(WitcherPotion witcherPotion)
        {
            _context.WitcherPotions.Add(witcherPotion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWitcherPotion", new { id = witcherPotion.ID }, witcherPotion);
        }

        // DELETE: api/WitcherPotions/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<WitcherPotion>> DeleteWitcherPotion(int id)
        {
            var witcherPotion = await _context.WitcherPotions.FindAsync(id);
            if (witcherPotion == null)
            {
                return NotFound();
            }

            witcherPotion.Deleted = true;
            _context.WitcherPotions.Update(witcherPotion);
            await _context.SaveChangesAsync();

            return witcherPotion;
        }

        private bool WitcherPotionExists(int id)
        {
            return _context.WitcherPotions.Any(e => e.ID == id);
        }
    }
}
