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
    public class CriticalTablesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CriticalTablesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CriticalTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CriticalTable>>> GetCriticalTables()
        {
            return await _context.CriticalTables.ToListAsync();
        }

        // GET: api/CriticalTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CriticalTable>> GetCriticalTable(int id)
        {
            var criticalTable = await _context.CriticalTables.FindAsync(id);

            if (criticalTable == null)
            {
                return NotFound();
            }

            return criticalTable;
        }

        // PUT: api/CriticalTables/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCriticalTable(int id, CriticalTable criticalTable)
        {
            if (id != criticalTable.ID)
            {
                return BadRequest();
            }

            _context.Entry(criticalTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriticalTableExists(id))
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

        // POST: api/CriticalTables
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CriticalTable>> PostCriticalTable(CriticalTable criticalTable)
        {
            _context.CriticalTables.Add(criticalTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCriticalTable", new { id = criticalTable.ID }, criticalTable);
        }

        // DELETE: api/CriticalTables/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CriticalTable>> DeleteCriticalTable(int id)
        {
            var criticalTable = await _context.CriticalTables.FindAsync(id);
            if (criticalTable == null)
            {
                return NotFound();
            }

            criticalTable.Deleted = true;
            _context.CriticalTables.Update(criticalTable);
            await _context.SaveChangesAsync();

            return criticalTable;
        }

        private bool CriticalTableExists(int id)
        {
            return _context.CriticalTables.Any(e => e.ID == id);
        }
    }
}
