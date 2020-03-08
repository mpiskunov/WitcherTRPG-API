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
    public class MonsterLootsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterLootsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterLoots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterLoot>>> GetMonsterLoots()
        {
            return await _context.MonsterLoots.ToListAsync();
        }

        // GET: api/MonsterLoots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterLoot>> GetMonsterLoot(int id)
        {
            var monsterLoot = await _context.MonsterLoots.FindAsync(id);

            if (monsterLoot == null)
            {
                return NotFound();
            }

            return monsterLoot;
        }

        // PUT: api/MonsterLoots/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterLoot(int id, MonsterLoot monsterLoot)
        {
            if (id != monsterLoot.ID)
            {
                return BadRequest();
            }

            _context.Entry(monsterLoot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterLootExists(id))
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

        // POST: api/MonsterLoots
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterLoot>> PostMonsterLoot(MonsterLoot monsterLoot)
        {
            _context.MonsterLoots.Add(monsterLoot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonsterLoot", new { id = monsterLoot.ID }, monsterLoot);
        }

        // DELETE: api/MonsterLoots/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterLoot>> DeleteMonsterLoot(int id)
        {
            var monsterLoot = await _context.MonsterLoots.FindAsync(id);
            if (monsterLoot == null)
            {
                return NotFound();
            }

            _context.MonsterLoots.Remove(monsterLoot);
            await _context.SaveChangesAsync();

            return monsterLoot;
        }

        private bool MonsterLootExists(int id)
        {
            return _context.MonsterLoots.Any(e => e.ID == id);
        }
    }
}
