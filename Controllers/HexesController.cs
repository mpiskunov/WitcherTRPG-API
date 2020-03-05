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
    public class HexesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public HexesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Hexes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hex>>> GetHexs()
        {
            return await _context.Hexs.ToListAsync();
        }

        // GET: api/Hexes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hex>> GetHex(int id)
        {
            var hex = await _context.Hexs.FindAsync(id);

            if (hex == null)
            {
                return NotFound();
            }

            return hex;
        }

        // PUT: api/Hexes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHex(int id, Hex hex)
        {
            if (id != hex.ID)
            {
                return BadRequest();
            }

            _context.Entry(hex).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HexExists(id))
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

        // POST: api/Hexes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Hex>> PostHex(Hex hex)
        {
            _context.Hexs.Add(hex);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHex", new { id = hex.ID }, hex);
        }

        // DELETE: api/Hexes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hex>> DeleteHex(int id)
        {
            var hex = await _context.Hexs.FindAsync(id);
            if (hex == null)
            {
                return NotFound();
            }

            _context.Hexs.Remove(hex);
            await _context.SaveChangesAsync();

            return hex;
        }

        private bool HexExists(int id)
        {
            return _context.Hexs.Any(e => e.ID == id);
        }
    }
}
