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
    public class MutagensController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MutagensController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Mutagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mutagen>>> GetMutagens()
        {
            return await _context.Mutagens.ToListAsync();
        }

        // GET: api/Mutagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mutagen>> GetMutagen(int id)
        {
            var mutagen = await _context.Mutagens.FindAsync(id);

            if (mutagen == null)
            {
                return NotFound();
            }

            return mutagen;
        }

        // PUT: api/Mutagens/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMutagen(int id, Mutagen mutagen)
        {
            if (id != mutagen.ID)
            {
                return BadRequest();
            }

            _context.Entry(mutagen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MutagenExists(id))
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

        // POST: api/Mutagens
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Mutagen>> PostMutagen(Mutagen mutagen)
        {
            _context.Mutagens.Add(mutagen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMutagen", new { id = mutagen.ID }, mutagen);
        }

        // DELETE: api/Mutagens/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<Mutagen>> DeleteMutagen(int id)
        {
            var mutagen = await _context.Mutagens.FindAsync(id);
            if (mutagen == null)
            {
                return NotFound();
            }

            mutagen.Deleted = true;
            _context.Mutagens.Update(mutagen);
            await _context.SaveChangesAsync();

            return mutagen;
        }

        private bool MutagenExists(int id)
        {
            return _context.Mutagens.Any(e => e.ID == id);
        }
    }
}
