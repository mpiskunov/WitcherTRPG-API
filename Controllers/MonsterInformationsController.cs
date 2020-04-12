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
    public class MonsterInformationsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonsterInformationsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MonsterInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterInformation>>> GetMonsterInformations()
        {
            return await _context.MonsterInformations.ToListAsync();
        }

        // GET: api/MonsterInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterInformation>> GetMonsterInformation(int id)
        {
            var monsterInformation = await _context.MonsterInformations.FindAsync(id);

            if (monsterInformation == null)
            {
                return NotFound();
            }

            return monsterInformation;
        }

        // PUT: api/MonsterInformations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonsterInformation(int id, MonsterInformation monsterInformation)
        {
            if (id != monsterInformation.ID)
            {
                return BadRequest();
            }

            _context.Entry(monsterInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterInformationExists(id))
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

        // POST: api/MonsterInformations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MonsterInformation>> PostMonsterInformation(MonsterInformation monsterInformation)
        {
            _context.MonsterInformations.Add(monsterInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonsterInformation", new { id = monsterInformation.ID }, monsterInformation);
        }

        // DELETE: api/MonsterInformations/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<MonsterInformation>> DeleteMonsterInformation(int id)
        {
            var monsterInformation = await _context.MonsterInformations.FindAsync(id);
            if (monsterInformation == null)
            {
                return NotFound();
            }

            monsterInformation.Deleted = true;
            _context.MonsterInformations.Update(monsterInformation);
            await _context.SaveChangesAsync();

            return monsterInformation;
        }

        private bool MonsterInformationExists(int id)
        {
            return _context.MonsterInformations.Any(e => e.ID == id);
        }
    }
}
