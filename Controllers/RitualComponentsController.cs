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
    public class RitualComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public RitualComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/RitualComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RitualComponent>>> GetRitualComponents()
        {
            return await _context.RitualComponents.ToListAsync();
        }

        // GET: api/RitualComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RitualComponent>> GetRitualComponent(int id)
        {
            var ritualComponent = await _context.RitualComponents.FindAsync(id);

            if (ritualComponent == null)
            {
                return NotFound();
            }

            return ritualComponent;
        }

        // PUT: api/RitualComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRitualComponent(int id, RitualComponent ritualComponent)
        {
            if (id != ritualComponent.ID)
            {
                return BadRequest();
            }

            _context.Entry(ritualComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RitualComponentExists(id))
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

        // POST: api/RitualComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RitualComponent>> PostRitualComponent(RitualComponent ritualComponent)
        {
            _context.RitualComponents.Add(ritualComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRitualComponent", new { id = ritualComponent.ID }, ritualComponent);
        }

        // DELETE: api/RitualComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RitualComponent>> DeleteRitualComponent(int id)
        {
            var ritualComponent = await _context.RitualComponents.FindAsync(id);
            if (ritualComponent == null)
            {
                return NotFound();
            }

            _context.RitualComponents.Remove(ritualComponent);
            await _context.SaveChangesAsync();

            return ritualComponent;
        }

        private bool RitualComponentExists(int id)
        {
            return _context.RitualComponents.Any(e => e.ID == id);
        }
    }
}
