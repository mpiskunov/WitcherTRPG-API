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
    public class DerivedStatisticsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public DerivedStatisticsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/DerivedStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DerivedStatistic>>> GetDerivedStatistic()
        {
            return await _context.DerivedStatistic.ToListAsync();
        }

        // GET: api/DerivedStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DerivedStatistic>> GetDerivedStatistic(int id)
        {
            var derivedStatistic = await _context.DerivedStatistic.FindAsync(id);

            if (derivedStatistic == null)
            {
                return NotFound();
            }

            return derivedStatistic;
        }

        // PUT: api/DerivedStatistics/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDerivedStatistic(int id, DerivedStatistic derivedStatistic)
        {
            if (id != derivedStatistic.ID)
            {
                return BadRequest();
            }

            _context.Entry(derivedStatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DerivedStatisticExists(id))
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

        // POST: api/DerivedStatistics
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DerivedStatistic>> PostDerivedStatistic(DerivedStatistic derivedStatistic)
        {
            _context.DerivedStatistic.Add(derivedStatistic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDerivedStatistic", new { id = derivedStatistic.ID }, derivedStatistic);
        }

        // DELETE: api/Formulae/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<DerivedStatistic>> DeleteFormulae(int id)
        {
            var derivedStatistic = await _context.DerivedStatistic.FindAsync(id);
            if (derivedStatistic == null)
            {
                return NotFound();
            }

            derivedStatistic.Deleted = true;
            _context.DerivedStatistic.Update(derivedStatistic);
            await _context.SaveChangesAsync();

            return derivedStatistic;
        }

        private bool DerivedStatisticExists(int id)
        {
            return _context.DerivedStatistic.Any(e => e.ID == id);
        }
    }
}
