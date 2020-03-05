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
    public class RammingSizeModifiersController : ControllerBase
    {
        private readonly WitcherContext _context;

        public RammingSizeModifiersController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/RammingSizeModifiers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RammingSizeModifier>>> GetRammingSizeModifiers()
        {
            return await _context.RammingSizeModifiers.ToListAsync();
        }

        // GET: api/RammingSizeModifiers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RammingSizeModifier>> GetRammingSizeModifier(int id)
        {
            var rammingSizeModifier = await _context.RammingSizeModifiers.FindAsync(id);

            if (rammingSizeModifier == null)
            {
                return NotFound();
            }

            return rammingSizeModifier;
        }

        // PUT: api/RammingSizeModifiers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRammingSizeModifier(int id, RammingSizeModifier rammingSizeModifier)
        {
            if (id != rammingSizeModifier.ID)
            {
                return BadRequest();
            }

            _context.Entry(rammingSizeModifier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RammingSizeModifierExists(id))
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

        // POST: api/RammingSizeModifiers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RammingSizeModifier>> PostRammingSizeModifier(RammingSizeModifier rammingSizeModifier)
        {
            _context.RammingSizeModifiers.Add(rammingSizeModifier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRammingSizeModifier", new { id = rammingSizeModifier.ID }, rammingSizeModifier);
        }

        // DELETE: api/RammingSizeModifiers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RammingSizeModifier>> DeleteRammingSizeModifier(int id)
        {
            var rammingSizeModifier = await _context.RammingSizeModifiers.FindAsync(id);
            if (rammingSizeModifier == null)
            {
                return NotFound();
            }

            _context.RammingSizeModifiers.Remove(rammingSizeModifier);
            await _context.SaveChangesAsync();

            return rammingSizeModifier;
        }

        private bool RammingSizeModifierExists(int id)
        {
            return _context.RammingSizeModifiers.Any(e => e.ID == id);
        }
    }
}
