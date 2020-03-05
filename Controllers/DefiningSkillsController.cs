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
    public class DefiningSkillsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public DefiningSkillsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/DefiningSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DefiningSkill>>> GetDefiningSkills()
        {
            return await _context.DefiningSkills.ToListAsync();
        }

        // GET: api/DefiningSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DefiningSkill>> GetDefiningSkill(int id)
        {
            var definingSkill = await _context.DefiningSkills.FindAsync(id);

            if (definingSkill == null)
            {
                return NotFound();
            }

            return definingSkill;
        }

        // PUT: api/DefiningSkills/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDefiningSkill(int id, DefiningSkill definingSkill)
        {
            if (id != definingSkill.ID)
            {
                return BadRequest();
            }

            _context.Entry(definingSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DefiningSkillExists(id))
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

        // POST: api/DefiningSkills
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DefiningSkill>> PostDefiningSkill(DefiningSkill definingSkill)
        {
            _context.DefiningSkills.Add(definingSkill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDefiningSkill", new { id = definingSkill.ID }, definingSkill);
        }

        // DELETE: api/DefiningSkills/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DefiningSkill>> DeleteDefiningSkill(int id)
        {
            var definingSkill = await _context.DefiningSkills.FindAsync(id);
            if (definingSkill == null)
            {
                return NotFound();
            }

            _context.DefiningSkills.Remove(definingSkill);
            await _context.SaveChangesAsync();

            return definingSkill;
        }

        private bool DefiningSkillExists(int id)
        {
            return _context.DefiningSkills.Any(e => e.ID == id);
        }
    }
}
