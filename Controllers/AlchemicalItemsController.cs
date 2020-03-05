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
    public class AlchemicalItemsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AlchemicalItemsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/AlchemicalItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlchemicalItem>>> GetAlchemicalItems()
        {
            return await _context.AlchemicalItems.ToListAsync();
        }

        // GET: api/AlchemicalItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlchemicalItem>> GetAlchemicalItem(int id)
        {
            var alchemicalItem = await _context.AlchemicalItems.FindAsync(id);

            if (alchemicalItem == null)
            {
                return NotFound();
            }

            return alchemicalItem;
        }

        // PUT: api/AlchemicalItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlchemicalItem(int id, AlchemicalItem alchemicalItem)
        {
            if (id != alchemicalItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(alchemicalItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlchemicalItemExists(id))
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

        // POST: api/AlchemicalItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AlchemicalItem>> PostAlchemicalItem(AlchemicalItem alchemicalItem)
        {
            _context.AlchemicalItems.Add(alchemicalItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlchemicalItem", new { id = alchemicalItem.ID }, alchemicalItem);
        }

        // DELETE: api/AlchemicalItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AlchemicalItem>> DeleteAlchemicalItem(int id)
        {
            var alchemicalItem = await _context.AlchemicalItems.FindAsync(id);
            if (alchemicalItem == null)
            {
                return NotFound();
            }

            _context.AlchemicalItems.Remove(alchemicalItem);
            await _context.SaveChangesAsync();

            return alchemicalItem;
        }

        private bool AlchemicalItemExists(int id)
        {
            return _context.AlchemicalItems.Any(e => e.ID == id);
        }
    }
}
