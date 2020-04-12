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
    public class MonsterDerivedStatisticsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterDerivedStatisticsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterDerivedStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterDerivedStatistic>>> GetMonsterDerivedStatistics()
        {
            return await _context.MonsterDerivedStatistics.ToListAsync();
        }

        // GET: api/MonsterDerivedStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterDerivedStatistic>> GetMonsterDerivedStatistic(int id)
        {
            var monsterDerivedStatistic = await _context.MonsterDerivedStatistics.FindAsync(id);

            if (monsterDerivedStatistic == null)
            {
                return NotFound();
            }

            return monsterDerivedStatistic;
        }

        // PUT: api/MonsterDerivedStatistics/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterDerivedStatistic(int id, MonsterDerivedStatistic monsterDerivedStatistic)
        {
            if (id != monsterDerivedStatistic.MonsterID)
            {
                return BadRequest();
            }

            _context.Entry(monsterDerivedStatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterDerivedStatisticExists(id))
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

        // POST: api/MonsterDerivedStatistics
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterDerivedStatistic>> PostMonsterDerivedStatistic(MonsterDerivedStatistic monsterDerivedStatistic)
        {
            _context.MonsterDerivedStatistics.Add(monsterDerivedStatistic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MonsterDerivedStatisticExists(monsterDerivedStatistic.MonsterID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMonsterDerivedStatistic", new { id = monsterDerivedStatistic.MonsterID }, monsterDerivedStatistic);
        }

        // DELETE: api/MonsterDerivedStatistics/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<MonsterDerivedStatistic>> DeleteMonsterDerivedStatistic(int id)
        {
            var monsterDerivedStatistic = await _context.MonsterDerivedStatistics.FindAsync(id);
            if (monsterDerivedStatistic == null)
            {
                return NotFound();
            }

            monsterDerivedStatistic.Deleted = true;
            _context.MonsterDerivedStatistics.Update(monsterDerivedStatistic);
            await _context.SaveChangesAsync();

            return monsterDerivedStatistic;
        }

        private bool MonsterDerivedStatisticExists(int id)
        {
            return _context.MonsterDerivedStatistics.Any(e => e.MonsterID == id);
        }
    }
}
