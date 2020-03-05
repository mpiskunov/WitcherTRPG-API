using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPGWebApplication.Data;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftingDiagramComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CraftingDiagramComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CraftingDiagramComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraftingDiagramComponent>>> GetCraftingDiagramComponents()
        {
            return await _context.CraftingDiagramComponents.ToListAsync();
        }

        // GET: api/CraftingDiagramComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraftingDiagramComponent>> GetCraftingDiagramComponent(int id)
        {
            var craftingDiagramComponent = await _context.CraftingDiagramComponents.FindAsync(id);

            if (craftingDiagramComponent == null)
            {
                return NotFound();
            }

            return craftingDiagramComponent;
        }

        // PUT: api/CraftingDiagramComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraftingDiagramComponent(int id, CraftingDiagramComponent craftingDiagramComponent)
        {
            if (id != craftingDiagramComponent.CraftingDiagramID)
            {
                return BadRequest();
            }

            _context.Entry(craftingDiagramComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraftingDiagramComponentExists(id))
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

        // POST: api/CraftingDiagramComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CraftingDiagramComponent>> PostCraftingDiagramComponent(CraftingDiagramComponent craftingDiagramComponent)
        {
            _context.CraftingDiagramComponents.Add(craftingDiagramComponent);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraftingDiagramComponentExists(craftingDiagramComponent.CraftingDiagramID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraftingDiagramComponent", new { id = craftingDiagramComponent.CraftingDiagramID }, craftingDiagramComponent);
        }

        // DELETE: api/CraftingDiagramComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CraftingDiagramComponent>> DeleteCraftingDiagramComponent(int id)
        {
            var craftingDiagramComponent = await _context.CraftingDiagramComponents.FindAsync(id);
            if (craftingDiagramComponent == null)
            {
                return NotFound();
            }

            _context.CraftingDiagramComponents.Remove(craftingDiagramComponent);
            await _context.SaveChangesAsync();

            return craftingDiagramComponent;
        }

        private bool CraftingDiagramComponentExists(int id)
        {
            return _context.CraftingDiagramComponents.Any(e => e.CraftingDiagramID == id);
        }
    }
}
