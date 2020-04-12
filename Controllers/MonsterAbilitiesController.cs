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
    public class MonsterAbilitiesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterAbilitiesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterAbilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterAbility>>> GetMonsterAbilities()
        {
            return await _context.MonsterAbilities.ToListAsync();
        }

        // GET: api/MonsterAbilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterAbility>> GetMonsterAbility(int id)
        {
            var monsterAbility = await _context.MonsterAbilities.FindAsync(id);

            if (monsterAbility == null)
            {
                return NotFound();
            }

            return monsterAbility;
        }

        // PUT: api/MonsterAbilities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterAbility(int id, MonsterAbility monsterAbility)
        {
            if (id != monsterAbility.ID)
            {
                return BadRequest();
            }

            _context.Entry(monsterAbility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterAbilityExists(id))
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

        // POST: api/MonsterAbilities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterAbility>> PostMonsterAbility(MonsterAbility monsterAbility)
        {
            _context.MonsterAbilities.Add(monsterAbility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonsterAbility", new { id = monsterAbility.ID }, monsterAbility);
        }

        // DELETE: api/MonsterAbilities/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<MonsterAbility>> DeleteMonsterAbility(int id)
        {
            var monsterAbility = await _context.MonsterAbilities.FindAsync(id);
            if (monsterAbility == null)
            {
                return NotFound();
            }

            monsterAbility.Deleted = true;
            _context.MonsterAbilities.Update(monsterAbility);
            await _context.SaveChangesAsync();

            return monsterAbility;
        }

        private bool MonsterAbilityExists(int id)
        {
            return _context.MonsterAbilities.Any(e => e.ID == id);
        }
    }
}
