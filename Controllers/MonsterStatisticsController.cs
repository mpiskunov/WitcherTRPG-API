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
    public class MonsterStatisticsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterStatisticsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterStatistic>>> GetMonsterStatistics()
        {
            return await _context.MonsterStatistics.Include(ms => ms.Statistic).ToListAsync();
        }

        // GET: api/MonsterStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterStatistic>> GetMonsterStatistic(int id)
        {
            var monsterStatistic = await _context.MonsterStatistics.FindAsync(id);

            if (monsterStatistic == null)
            {
                return NotFound();
            }

            return monsterStatistic;
        }

        // PUT: api/MonsterStatistics/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterStatistic(int id, MonsterStatistic monsterStatistic)
        {
            if (id != monsterStatistic.MonsterID)
            {
                return BadRequest();
            }

            _context.Entry(monsterStatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterStatisticExists(id))
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

        // POST: api/MonsterStatistics
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterStatistic>> PostMonsterStatistic(MonsterStatistic monsterStatistic)
        {
            _context.MonsterStatistics.Add(monsterStatistic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MonsterStatisticExists(monsterStatistic.MonsterID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMonsterStatistic", new { id = monsterStatistic.MonsterID }, monsterStatistic);
        }

        // DELETE: api/MonsterStatistics/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<MonsterStatistic>> DeleteMonsterStatistic(int id)
        {
            var monsterStatistic = await _context.MonsterStatistics.FindAsync(id);
            if (monsterStatistic == null)
            {
                return NotFound();
            }

            monsterStatistic.Deleted = true;
            _context.MonsterStatistics.Update(monsterStatistic);
            await _context.SaveChangesAsync();

            return monsterStatistic;
        }

        private bool MonsterStatisticExists(int id)
        {
            return _context.MonsterStatistics.Any(e => e.MonsterID == id);
        }
    }
}
