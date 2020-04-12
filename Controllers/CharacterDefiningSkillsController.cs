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
    public class CharacterDefiningSkillsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterDefiningSkillsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterDefiningSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterDefiningSkill>>> GetCharacterDefiningSkills()
        {
            return await _context.CharacterDefiningSkills.ToListAsync();
        }

        // GET: api/CharacterDefiningSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDefiningSkill>> GetCharacterDefiningSkill(int id)
        {
            var characterDefiningSkill = await _context.CharacterDefiningSkills.FindAsync(id);

            if (characterDefiningSkill == null)
            {
                return NotFound();
            }

            return characterDefiningSkill;
        }

        // PUT: api/CharacterDefiningSkills/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterDefiningSkill(int id, CharacterDefiningSkill characterDefiningSkill)
        {
            if (id != characterDefiningSkill.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterDefiningSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterDefiningSkillExists(id))
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

        // POST: api/CharacterDefiningSkills
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterDefiningSkill>> PostCharacterDefiningSkill(CharacterDefiningSkill characterDefiningSkill)
        {
            _context.CharacterDefiningSkills.Add(characterDefiningSkill);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterDefiningSkillExists(characterDefiningSkill.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterDefiningSkill", new { id = characterDefiningSkill.CharacterSheetID }, characterDefiningSkill);
        }

        // DELETE: api/CharacterDefiningSkills/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterDefiningSkill>> DeleteCharacterDefiningSkill(int id)
        {
            var characterDefiningSkill = await _context.CharacterDefiningSkills.FindAsync(id);
            if (characterDefiningSkill == null)
            {
                return NotFound();
            }

            characterDefiningSkill.Deleted = true;
            _context.CharacterDefiningSkills.Update(characterDefiningSkill);
            await _context.SaveChangesAsync();

            return characterDefiningSkill;
        }

        private bool CharacterDefiningSkillExists(int id)
        {
            return _context.CharacterDefiningSkills.Any(e => e.CharacterSheetID == id);
        }
    }
}
