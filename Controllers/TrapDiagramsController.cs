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
    public class TrapDiagramsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public TrapDiagramsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/TrapDiagrams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrapDiagram>>> GetTrapDiagrams()
        {
            return await _context.TrapDiagrams.ToListAsync();
        }

        // GET: api/TrapDiagrams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrapDiagram>> GetTrapDiagram(int id)
        {
            var trapDiagram = await _context.TrapDiagrams.FindAsync(id);

            if (trapDiagram == null)
            {
                return NotFound();
            }

            return trapDiagram;
        }

        // PUT: api/TrapDiagrams/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrapDiagram(int id, TrapDiagram trapDiagram)
        {
            if (id != trapDiagram.ID)
            {
                return BadRequest();
            }

            _context.Entry(trapDiagram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrapDiagramExists(id))
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

        // POST: api/TrapDiagrams
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TrapDiagram>> PostTrapDiagram(TrapDiagram trapDiagram)
        {
            _context.TrapDiagrams.Add(trapDiagram);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrapDiagram", new { id = trapDiagram.ID }, trapDiagram);
        }

        // DELETE: api/TrapDiagrams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrapDiagram>> DeleteTrapDiagram(int id)
        {
            var trapDiagram = await _context.TrapDiagrams.FindAsync(id);
            if (trapDiagram == null)
            {
                return NotFound();
            }

            _context.TrapDiagrams.Remove(trapDiagram);
            await _context.SaveChangesAsync();

            return trapDiagram;
        }

        private bool TrapDiagramExists(int id)
        {
            return _context.TrapDiagrams.Any(e => e.ID == id);
        }
    }
}
