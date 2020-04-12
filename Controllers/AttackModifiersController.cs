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
    public class AttackModifiersController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AttackModifiersController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/AttackModifiers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttackModifier>>> GetAttackModifiers()
        {
            return await _context.AttackModifiers.ToListAsync();
        }

        // GET: api/AttackModifiers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AttackModifier>> GetAttackModifier(int id)
        {
            var attackModifier = await _context.AttackModifiers.FindAsync(id);

            if (attackModifier == null)
            {
                return NotFound();
            }

            return attackModifier;
        }

        // PUT: api/AttackModifiers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttackModifier(int id, AttackModifier attackModifier)
        {
            if (id != attackModifier.ID)
            {
                return BadRequest();
            }

            _context.Entry(attackModifier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttackModifierExists(id))
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

        // POST: api/AttackModifiers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AttackModifier>> PostAttackModifier(AttackModifier attackModifier)
        {
            _context.AttackModifiers.Add(attackModifier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttackModifier", new { id = attackModifier.ID }, attackModifier);
        }

        // DELETE: api/AttackModifiers/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<AttackModifier>> DeleteAttackModifier(int id)
        {
            var attackModifier = await _context.AttackModifiers.FindAsync(id);
            if (attackModifier == null)
            {
                return NotFound();
            }

            attackModifier.Deleted = true;
            _context.AttackModifiers.Update(attackModifier);
            await _context.SaveChangesAsync();

            return attackModifier;
        }

        private bool AttackModifierExists(int id)
        {
            return _context.AttackModifiers.Any(e => e.ID == id);
        }
    }
}
