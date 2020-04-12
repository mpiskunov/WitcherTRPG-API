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
    public class DefiningSkillTablesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public DefiningSkillTablesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/DefiningSkillTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DefiningSkillTable>>> GetDefiningSkillTables()
        {
            return await _context.DefiningSkillTables.ToListAsync();
        }

        // GET: api/DefiningSkillTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DefiningSkillTable>> GetDefiningSkillTable(int id)
        {
            var definingSkillTable = await _context.DefiningSkillTables.FindAsync(id);

            if (definingSkillTable == null)
            {
                return NotFound();
            }

            return definingSkillTable;
        }

        // PUT: api/DefiningSkillTables/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDefiningSkillTable(int id, DefiningSkillTable definingSkillTable)
        {
            if (id != definingSkillTable.ID)
            {
                return BadRequest();
            }

            _context.Entry(definingSkillTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DefiningSkillTableExists(id))
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

        // POST: api/DefiningSkillTables
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DefiningSkillTable>> PostDefiningSkillTable(DefiningSkillTable definingSkillTable)
        {
            _context.DefiningSkillTables.Add(definingSkillTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDefiningSkillTable", new { id = definingSkillTable.ID }, definingSkillTable);
        }

        // DELETE: api/DefiningSkillTables/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<DefiningSkillTable>> DeleteDefiningSkillTable(int id)
        {
            var definingSkillTable = await _context.DefiningSkillTables.FindAsync(id);
            if (definingSkillTable == null)
            {
                return NotFound();
            }

            definingSkillTable.Deleted = true;
            _context.DefiningSkillTables.Update(definingSkillTable);
            await _context.SaveChangesAsync();

            return definingSkillTable;
        }

        private bool DefiningSkillTableExists(int id)
        {
            return _context.DefiningSkillTables.Any(e => e.ID == id);
        }
    }
}
