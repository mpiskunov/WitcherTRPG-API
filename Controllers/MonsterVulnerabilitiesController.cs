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
    public class MonsterVulnerabilitiesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterVulnerabilitiesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterVulnerabilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterVulnerability>>> GetMonsterVulnerabilities()
        {
            return await _context.MonsterVulnerabilities.ToListAsync();
        }

        // GET: api/MonsterVulnerabilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterVulnerability>> GetMonsterVulnerability(int id)
        {
            var monsterVulnerability = await _context.MonsterVulnerabilities.FindAsync(id);

            if (monsterVulnerability == null)
            {
                return NotFound();
            }

            return monsterVulnerability;
        }

        // PUT: api/MonsterVulnerabilities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterVulnerability(int id, MonsterVulnerability monsterVulnerability)
        {
            if (id != monsterVulnerability.ID)
            {
                return BadRequest();
            }

            _context.Entry(monsterVulnerability).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterVulnerabilityExists(id))
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

        // POST: api/MonsterVulnerabilities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterVulnerability>> PostMonsterVulnerability(MonsterVulnerability monsterVulnerability)
        {
            _context.MonsterVulnerabilities.Add(monsterVulnerability);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonsterVulnerability", new { id = monsterVulnerability.ID }, monsterVulnerability);
        }

        // DELETE: api/MonsterVulnerabilities/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<MonsterVulnerability>> DeleteMonsterVulnerability(int id)
        {
            var monsterVulnerability = await _context.MonsterVulnerabilities.FindAsync(id);
            if (monsterVulnerability == null)
            {
                return NotFound();
            }

            monsterVulnerability.Deleted = true;
            _context.MonsterVulnerabilities.Update(monsterVulnerability);
            await _context.SaveChangesAsync();

            return monsterVulnerability;
        }

        private bool MonsterVulnerabilityExists(int id)
        {
            return _context.MonsterVulnerabilities.Any(e => e.ID == id);
        }
    }
}
