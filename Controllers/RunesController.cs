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
    public class RunesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public RunesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Runes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rune>>> GetRunes()
        {
            return await _context.Runes.ToListAsync();
        }

        // GET: api/Runes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rune>> GetRune(int id)
        {
            var rune = await _context.Runes.FindAsync(id);

            if (rune == null)
            {
                return NotFound();
            }

            return rune;
        }

        // PUT: api/Runes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRune(int id, Rune rune)
        {
            if (id != rune.ID)
            {
                return BadRequest();
            }

            _context.Entry(rune).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RuneExists(id))
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

        // POST: api/Runes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Rune>> PostRune(Rune rune)
        {
            _context.Runes.Add(rune);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRune", new { id = rune.ID }, rune);
        }

        // DELETE: api/Runes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rune>> DeleteRune(int id)
        {
            var rune = await _context.Runes.FindAsync(id);
            if (rune == null)
            {
                return NotFound();
            }

            _context.Runes.Remove(rune);
            await _context.SaveChangesAsync();

            return rune;
        }

        private bool RuneExists(int id)
        {
            return _context.Runes.Any(e => e.ID == id);
        }
    }
}
