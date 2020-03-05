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
    public class TrapDiagramComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public TrapDiagramComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/TrapDiagramComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrapDiagramComponent>>> GetTrapDiagramComponents()
        {
            return await _context.TrapDiagramComponents.ToListAsync();
        }

        // GET: api/TrapDiagramComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrapDiagramComponent>> GetTrapDiagramComponent(int id)
        {
            var trapDiagramComponent = await _context.TrapDiagramComponents.FindAsync(id);

            if (trapDiagramComponent == null)
            {
                return NotFound();
            }

            return trapDiagramComponent;
        }

        // PUT: api/TrapDiagramComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrapDiagramComponent(int id, TrapDiagramComponent trapDiagramComponent)
        {
            if (id != trapDiagramComponent.ID)
            {
                return BadRequest();
            }

            _context.Entry(trapDiagramComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrapDiagramComponentExists(id))
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

        // POST: api/TrapDiagramComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TrapDiagramComponent>> PostTrapDiagramComponent(TrapDiagramComponent trapDiagramComponent)
        {
            _context.TrapDiagramComponents.Add(trapDiagramComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrapDiagramComponent", new { id = trapDiagramComponent.ID }, trapDiagramComponent);
        }

        // DELETE: api/TrapDiagramComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrapDiagramComponent>> DeleteTrapDiagramComponent(int id)
        {
            var trapDiagramComponent = await _context.TrapDiagramComponents.FindAsync(id);
            if (trapDiagramComponent == null)
            {
                return NotFound();
            }

            _context.TrapDiagramComponents.Remove(trapDiagramComponent);
            await _context.SaveChangesAsync();

            return trapDiagramComponent;
        }

        private bool TrapDiagramComponentExists(int id)
        {
            return _context.TrapDiagramComponents.Any(e => e.ID == id);
        }
    }
}
