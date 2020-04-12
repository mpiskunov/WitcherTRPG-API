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
    public class GlyphsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public GlyphsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Glyphs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glyph>>> GetGlyphs()
        {
            return await _context.Glyphs.ToListAsync();
        }

        // GET: api/Glyphs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Glyph>> GetGlyph(int id)
        {
            var glyph = await _context.Glyphs.FindAsync(id);

            if (glyph == null)
            {
                return NotFound();
            }

            return glyph;
        }

        // PUT: api/Glyphs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlyph(int id, Glyph glyph)
        {
            if (id != glyph.ID)
            {
                return BadRequest();
            }

            _context.Entry(glyph).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlyphExists(id))
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

        // POST: api/Glyphs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Glyph>> PostGlyph(Glyph glyph)
        {
            _context.Glyphs.Add(glyph);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlyph", new { id = glyph.ID }, glyph);
        }

        // DELETE: api/Glyphs/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<Glyph>> DeleteGlyph(int id)
        {
            var glyph = await _context.Glyphs.FindAsync(id);
            if (glyph == null)
            {
                return NotFound();
            }

            glyph.Deleted = true;
            _context.Glyphs.Update(glyph);
            await _context.SaveChangesAsync();

            return glyph;
        }

        private bool GlyphExists(int id)
        {
            return _context.Glyphs.Any(e => e.ID == id);
        }
    }
}
