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
    public class WitcherDecoctionsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public WitcherDecoctionsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/WitcherDecoctions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WitcherDecoction>>> GetWitcherDecoctions()
        {
            return await _context.WitcherDecoctions.ToListAsync();
        }

        // GET: api/WitcherDecoctions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WitcherDecoction>> GetWitcherDecoction(int id)
        {
            var witcherDecoction = await _context.WitcherDecoctions.FindAsync(id);

            if (witcherDecoction == null)
            {
                return NotFound();
            }

            return witcherDecoction;
        }

        // PUT: api/WitcherDecoctions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWitcherDecoction(int id, WitcherDecoction witcherDecoction)
        {
            if (id != witcherDecoction.ID)
            {
                return BadRequest();
            }

            _context.Entry(witcherDecoction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WitcherDecoctionExists(id))
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

        // POST: api/WitcherDecoctions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WitcherDecoction>> PostWitcherDecoction(WitcherDecoction witcherDecoction)
        {
            _context.WitcherDecoctions.Add(witcherDecoction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWitcherDecoction", new { id = witcherDecoction.ID }, witcherDecoction);
        }

        // DELETE: api/WitcherDecoctions/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<WitcherDecoction>> DeleteWitcherDecoction(int id)
        {
            var witcherDecoction = await _context.WitcherDecoctions.FindAsync(id);
            if (witcherDecoction == null)
            {
                return NotFound();
            }

            witcherDecoction.Deleted = true;
            _context.WitcherDecoctions.Update(witcherDecoction);
            await _context.SaveChangesAsync();

            return witcherDecoction;
        }

        private bool WitcherDecoctionExists(int id)
        {
            return _context.WitcherDecoctions.Any(e => e.ID == id);
        }
    }
}
