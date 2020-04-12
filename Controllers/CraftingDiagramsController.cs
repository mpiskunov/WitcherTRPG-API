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
    public class CraftingDiagramsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CraftingDiagramsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CraftingDiagrams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraftingDiagram>>> GetCraftingDiagrams()
        {
            return await _context.CraftingDiagrams.ToListAsync();
        }

        // GET: api/CraftingDiagrams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraftingDiagram>> GetCraftingDiagram(int id)
        {
            var craftingDiagram = await _context.CraftingDiagrams.FindAsync(id);

            if (craftingDiagram == null)
            {
                return NotFound();
            }

            return craftingDiagram;
        }

        // PUT: api/CraftingDiagrams/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraftingDiagram(int id, CraftingDiagram craftingDiagram)
        {
            if (id != craftingDiagram.ID)
            {
                return BadRequest();
            }

            _context.Entry(craftingDiagram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraftingDiagramExists(id))
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

        // POST: api/CraftingDiagrams
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CraftingDiagram>> PostCraftingDiagram(CraftingDiagram craftingDiagram)
        {
            _context.CraftingDiagrams.Add(craftingDiagram);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCraftingDiagram", new { id = craftingDiagram.ID }, craftingDiagram);
        }

        // DELETE: api/CraftingDiagrams/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CraftingDiagram>> DeleteCraftingDiagram(int id)
        {
            var craftingDiagram = await _context.CraftingDiagrams.FindAsync(id);
            if (craftingDiagram == null)
            {
                return NotFound();
            }

            craftingDiagram.Deleted = true;
            _context.CraftingDiagrams.Update(craftingDiagram);
            await _context.SaveChangesAsync();

            return craftingDiagram;
        }

        private bool CraftingDiagramExists(int id)
        {
            return _context.CraftingDiagrams.Any(e => e.ID == id);
        }
    }
}
