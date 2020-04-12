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
    public class ToolKitsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public ToolKitsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/ToolKits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToolKit>>> GetToolKits()
        {
            return await _context.ToolKits.ToListAsync();
        }

        // GET: api/ToolKits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToolKit>> GetToolKit(int id)
        {
            var toolKit = await _context.ToolKits.FindAsync(id);

            if (toolKit == null)
            {
                return NotFound();
            }

            return toolKit;
        }

        // PUT: api/ToolKits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToolKit(int id, ToolKit toolKit)
        {
            if (id != toolKit.ID)
            {
                return BadRequest();
            }

            _context.Entry(toolKit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToolKitExists(id))
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

        // POST: api/ToolKits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ToolKit>> PostToolKit(ToolKit toolKit)
        {
            _context.ToolKits.Add(toolKit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToolKit", new { id = toolKit.ID }, toolKit);
        }

        // DELETE: api/ToolKits/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<ToolKit>> DeleteToolKit(int id)
        {
            var toolKit = await _context.ToolKits.FindAsync(id);
            if (toolKit == null)
            {
                return NotFound();
            }

            toolKit.Deleted = true;
            _context.ToolKits.Update(toolKit);
            await _context.SaveChangesAsync();

            return toolKit;
        }

        private bool ToolKitExists(int id)
        {
            return _context.ToolKits.Any(e => e.ID == id);
        }
    }
}
