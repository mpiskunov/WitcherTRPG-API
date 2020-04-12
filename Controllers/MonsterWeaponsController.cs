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
    public class MonsterWeaponsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterWeaponsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterWeapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterWeapon>>> GetMonsterWeapons()
        {
            return await _context.MonsterWeapons.ToListAsync();
        }

        // GET: api/MonsterWeapons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterWeapon>> GetMonsterWeapon(int id)
        {
            var monsterWeapon = await _context.MonsterWeapons.FindAsync(id);

            if (monsterWeapon == null)
            {
                return NotFound();
            }

            return monsterWeapon;
        }

        // PUT: api/MonsterWeapons/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterWeapon(int id, MonsterWeapon monsterWeapon)
        {
            if (id != monsterWeapon.ID)
            {
                return BadRequest();
            }

            _context.Entry(monsterWeapon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterWeaponExists(id))
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

        // POST: api/MonsterWeapons
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterWeapon>> PostMonsterWeapon(MonsterWeapon monsterWeapon)
        {
            _context.MonsterWeapons.Add(monsterWeapon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonsterWeapon", new { id = monsterWeapon.ID }, monsterWeapon);
        }

        // DELETE: api/MonsterWeapons/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<MonsterWeapon>> DeleteMonsterWeapon(int id)
        {
            var monsterWeapon = await _context.MonsterWeapons.FindAsync(id);
            if (monsterWeapon == null)
            {
                return NotFound();
            }

            monsterWeapon.Deleted = true;
            _context.MonsterWeapons.Update(monsterWeapon);
            await _context.SaveChangesAsync();

            return monsterWeapon;
        }

        private bool MonsterWeaponExists(int id)
        {
            return _context.MonsterWeapons.Any(e => e.ID == id);
        }
    }
}
