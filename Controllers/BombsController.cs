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
    public class BombsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public BombsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Bombs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bomb>>> GetBombs()
        {
            return await _context.Bombs.ToListAsync();
        }

        // GET: api/Bombs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bomb>> GetBomb(int id)
        {
            var bomb = await _context.Bombs.FindAsync(id);

            if (bomb == null)
            {
                return NotFound();
            }

            return bomb;
        }

        // PUT: api/Bombs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBomb(int id, Bomb bomb)
        {
            if (id != bomb.ID)
            {
                return BadRequest();
            }

            _context.Entry(bomb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BombExists(id))
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

        // POST: api/Bombs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Bomb>> PostBomb(Bomb bomb)
        {
            _context.Bombs.Add(bomb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBomb", new { id = bomb.ID }, bomb);
        }

        // DELETE: api/Bombs/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<Bomb>> DeleteBomb(int id)
        {
            var bomb = await _context.Bombs.FindAsync(id);
            if (bomb == null)
            {
                return NotFound();
            }

            bomb.Deleted = true;
            _context.Bombs.Update(bomb);
            await _context.SaveChangesAsync();

            return bomb;
        }

        private bool BombExists(int id)
        {
            return _context.Bombs.Any(e => e.ID == id);
        }
    }
}
