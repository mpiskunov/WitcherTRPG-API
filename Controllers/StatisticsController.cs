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
    public class StatisticsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public StatisticsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Statistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Statistic>>> GetStatistics()
        {
            return await _context.Statistics.ToListAsync();
        }

        // GET: api/Statistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Statistic>> GetStatistic(int id)
        {
            var statistic = await _context.Statistics.FindAsync(id);

            if (statistic == null)
            {
                return NotFound();
            }

            return statistic;
        }

        // PUT: api/Statistics/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatistic(int id, Statistic statistic)
        {
            if (id != statistic.ID)
            {
                return BadRequest();
            }

            _context.Entry(statistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatisticExists(id))
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

        // POST: api/Statistics
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Statistic>> PostStatistic(Statistic statistic)
        {
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatistic", new { id = statistic.ID }, statistic);
        }

        // DELETE: api/Statistics/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<Statistic>> DeleteStatistic(int id)
        {
            var statistic = await _context.Statistics.FindAsync(id);
            if (statistic == null)
            {
                return NotFound();
            }

            statistic.Deleted = true;
            _context.Statistics.Update(statistic);
            await _context.SaveChangesAsync();

            return statistic;
        }

        private bool StatisticExists(int id)
        {
            return _context.Statistics.Any(e => e.ID == id);
        }
    }
}
