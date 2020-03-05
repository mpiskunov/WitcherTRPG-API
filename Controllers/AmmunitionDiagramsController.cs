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
    public class AmmunitionDiagramsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AmmunitionDiagramsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/AmmunitionDiagrams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmmunitionDiagram>>> GetAmmunitionDiagrams()
        {
            return await _context.AmmunitionDiagrams.ToListAsync();
        }

        // GET: api/AmmunitionDiagrams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AmmunitionDiagram>> GetAmmunitionDiagram(int id)
        {
            var ammunitionDiagram = await _context.AmmunitionDiagrams.FindAsync(id);

            if (ammunitionDiagram == null)
            {
                return NotFound();
            }

            return ammunitionDiagram;
        }

        // PUT: api/AmmunitionDiagrams/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmmunitionDiagram(int id, AmmunitionDiagram ammunitionDiagram)
        {
            if (id != ammunitionDiagram.ID)
            {
                return BadRequest();
            }

            _context.Entry(ammunitionDiagram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmmunitionDiagramExists(id))
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

        // POST: api/AmmunitionDiagrams
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AmmunitionDiagram>> PostAmmunitionDiagram(AmmunitionDiagram ammunitionDiagram)
        {
            _context.AmmunitionDiagrams.Add(ammunitionDiagram);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmmunitionDiagram", new { id = ammunitionDiagram.ID }, ammunitionDiagram);
        }

        // DELETE: api/AmmunitionDiagrams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AmmunitionDiagram>> DeleteAmmunitionDiagram(int id)
        {
            var ammunitionDiagram = await _context.AmmunitionDiagrams.FindAsync(id);
            if (ammunitionDiagram == null)
            {
                return NotFound();
            }

            _context.AmmunitionDiagrams.Remove(ammunitionDiagram);
            await _context.SaveChangesAsync();

            return ammunitionDiagram;
        }

        private bool AmmunitionDiagramExists(int id)
        {
            return _context.AmmunitionDiagrams.Any(e => e.ID == id);
        }
    }
}
