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
    public class FumblesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public FumblesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Fumbles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fumble>>> GetFumbles()
        {
            return await _context.Fumbles.ToListAsync();
        }

        // GET: api/Fumbles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fumble>> GetFumble(int id)
        {
            var fumble = await _context.Fumbles.FindAsync(id);

            if (fumble == null)
            {
                return NotFound();
            }

            return fumble;
        }

        // PUT: api/Fumbles/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFumble(int id, Fumble fumble)
        {
            if (id != fumble.ID)
            {
                return BadRequest();
            }

            _context.Entry(fumble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FumbleExists(id))
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

        // POST: api/Fumbles
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Fumble>> PostFumble(Fumble fumble)
        {
            _context.Fumbles.Add(fumble);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFumble", new { id = fumble.ID }, fumble);
        }

        // DELETE: api/Fumbles/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<Fumble>> DeleteFumble(int id)
        {
            var fumble = await _context.Fumbles.FindAsync(id);
            if (fumble == null)
            {
                return NotFound();
            }

            fumble.Deleted = true;
            _context.Fumbles.Update(fumble);
            await _context.SaveChangesAsync();

            return fumble;
        }

        private bool FumbleExists(int id)
        {
            return _context.Fumbles.Any(e => e.ID == id);
        }
    }
}
