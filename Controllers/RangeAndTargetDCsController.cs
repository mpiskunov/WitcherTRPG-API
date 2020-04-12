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
    public class RangeAndTargetDCsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public RangeAndTargetDCsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/RangeAndTargetDCs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RangeAndTargetDC>>> GetRangeAndTargetDCs()
        {
            return await _context.RangeAndTargetDCs.ToListAsync();
        }

        // GET: api/RangeAndTargetDCs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RangeAndTargetDC>> GetRangeAndTargetDC(int id)
        {
            var rangeAndTargetDC = await _context.RangeAndTargetDCs.FindAsync(id);

            if (rangeAndTargetDC == null)
            {
                return NotFound();
            }

            return rangeAndTargetDC;
        }

        // PUT: api/RangeAndTargetDCs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRangeAndTargetDC(int id, RangeAndTargetDC rangeAndTargetDC)
        {
            if (id != rangeAndTargetDC.ID)
            {
                return BadRequest();
            }

            _context.Entry(rangeAndTargetDC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RangeAndTargetDCExists(id))
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

        // POST: api/RangeAndTargetDCs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RangeAndTargetDC>> PostRangeAndTargetDC(RangeAndTargetDC rangeAndTargetDC)
        {
            _context.RangeAndTargetDCs.Add(rangeAndTargetDC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRangeAndTargetDC", new { id = rangeAndTargetDC.ID }, rangeAndTargetDC);
        }

        // DELETE: api/RangeAndTargetDCs/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<RangeAndTargetDC>> DeleteRangeAndTargetDC(int id)
        {
            var rangeAndTargetDC = await _context.RangeAndTargetDCs.FindAsync(id);
            if (rangeAndTargetDC == null)
            {
                return NotFound();
            }

            rangeAndTargetDC.Deleted = true;
            _context.RangeAndTargetDCs.Update(rangeAndTargetDC);
            await _context.SaveChangesAsync();

            return rangeAndTargetDC;
        }

        private bool RangeAndTargetDCExists(int id)
        {
            return _context.RangeAndTargetDCs.Any(e => e.ID == id);
        }
    }
}
