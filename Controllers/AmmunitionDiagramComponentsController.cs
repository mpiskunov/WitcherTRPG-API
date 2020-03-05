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
    public class AmmunitionDiagramComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AmmunitionDiagramComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/AmmunitionDiagramComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmmunitionDiagramComponent>>> GetAmmunitionDiagramComponents()
        {
            return await _context.AmmunitionDiagramComponents.ToListAsync();
        }

        // GET: api/AmmunitionDiagramComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AmmunitionDiagramComponent>> GetAmmunitionDiagramComponent(int id)
        {
            var ammunitionDiagramComponent = await _context.AmmunitionDiagramComponents.FindAsync(id);

            if (ammunitionDiagramComponent == null)
            {
                return NotFound();
            }

            return ammunitionDiagramComponent;
        }

        // PUT: api/AmmunitionDiagramComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmmunitionDiagramComponent(int id, AmmunitionDiagramComponent ammunitionDiagramComponent)
        {
            if (id != ammunitionDiagramComponent.ID)
            {
                return BadRequest();
            }

            _context.Entry(ammunitionDiagramComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmmunitionDiagramComponentExists(id))
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

        // POST: api/AmmunitionDiagramComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AmmunitionDiagramComponent>> PostAmmunitionDiagramComponent(AmmunitionDiagramComponent ammunitionDiagramComponent)
        {
            _context.AmmunitionDiagramComponents.Add(ammunitionDiagramComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmmunitionDiagramComponent", new { id = ammunitionDiagramComponent.ID }, ammunitionDiagramComponent);
        }

        // DELETE: api/AmmunitionDiagramComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AmmunitionDiagramComponent>> DeleteAmmunitionDiagramComponent(int id)
        {
            var ammunitionDiagramComponent = await _context.AmmunitionDiagramComponents.FindAsync(id);
            if (ammunitionDiagramComponent == null)
            {
                return NotFound();
            }

            _context.AmmunitionDiagramComponents.Remove(ammunitionDiagramComponent);
            await _context.SaveChangesAsync();

            return ammunitionDiagramComponent;
        }

        private bool AmmunitionDiagramComponentExists(int id)
        {
            return _context.AmmunitionDiagramComponents.Any(e => e.ID == id);
        }
    }
}
