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
    public class MonsterSkillsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterSkillsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterSkill>>> GetMonsterSkills()
        {
            return await _context.MonsterSkills.ToListAsync();
        }

        // GET: api/MonsterSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterSkill>> GetMonsterSkill(int id)
        {
            var monsterSkill = await _context.MonsterSkills.FindAsync(id);

            if (monsterSkill == null)
            {
                return NotFound();
            }

            return monsterSkill;
        }

        // PUT: api/MonsterSkills/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterSkill(int id, MonsterSkill monsterSkill)
        {
            if (id != monsterSkill.ID)
            {
                return BadRequest();
            }

            _context.Entry(monsterSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterSkillExists(id))
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

        // POST: api/MonsterSkills
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterSkill>> PostMonsterSkill(MonsterSkill monsterSkill)
        {
            _context.MonsterSkills.Add(monsterSkill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonsterSkill", new { id = monsterSkill.ID }, monsterSkill);
        }

        // DELETE: api/MonsterSkills/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterSkill>> DeleteMonsterSkill(int id)
        {
            var monsterSkill = await _context.MonsterSkills.FindAsync(id);
            if (monsterSkill == null)
            {
                return NotFound();
            }

            _context.MonsterSkills.Remove(monsterSkill);
            await _context.SaveChangesAsync();

            return monsterSkill;
        }

        private bool MonsterSkillExists(int id)
        {
            return _context.MonsterSkills.Any(e => e.ID == id);
        }
    }
}
