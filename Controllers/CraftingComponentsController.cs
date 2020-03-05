using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPGWebApplication.Data;
using WitcherTRPGWebApplication.Interfaces;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CraftingComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CraftingComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CraftingComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraftingComponent>>> GetCraftingComponents()
        {
            return await _context.CraftingComponents.ToListAsync();
        }

        // GET: api/CraftingComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraftingComponent>> GetCraftingComponent(int id)
        {
            var craftingComponent = await _context.CraftingComponents.FindAsync(id);

            if (craftingComponent == null)
            {
                return NotFound();
            }

            return craftingComponent;
        }

        // PUT: api/CraftingComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraftingComponent(int id, CraftingComponent craftingComponent)
        {
            if (id != craftingComponent.ID)
            {
                return BadRequest();
            }

            _context.Entry(craftingComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraftingComponentExists(id))
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

        // POST: api/CraftingComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CraftingComponent>> PostCraftingComponent(CraftingComponent craftingComponent)
        {
            _context.CraftingComponents.Add(craftingComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCraftingComponent", new { id = craftingComponent.ID }, craftingComponent);
        }

        // DELETE: api/CraftingComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CraftingComponent>> DeleteCraftingComponent(int id)
        {
            var craftingComponent = await _context.CraftingComponents.FindAsync(id);
            if (craftingComponent == null)
            {
                return NotFound();
            }

            _context.CraftingComponents.Remove(craftingComponent);
            await _context.SaveChangesAsync();

            return craftingComponent;
        }

        private bool CraftingComponentExists(int id)
        {
            return _context.CraftingComponents.Any(e => e.ID == id);
        }
    }
}
