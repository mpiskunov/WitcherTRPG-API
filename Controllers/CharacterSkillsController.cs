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
    public class CharacterSkillsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterSkillsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSkill>>> GetCharacterSkills()
        {
            return await _context.CharacterSkills.ToListAsync();
        }

        // GET: api/CharacterSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSkill>> GetCharacterSkill(int id)
        {
            var characterSkill = await _context.CharacterSkills.FindAsync(id);

            if (characterSkill == null)
            {
                return NotFound();
            }

            return characterSkill;
        }

        // PUT: api/CharacterSkills/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterSkill(int id, CharacterSkill characterSkill)
        {
            if (id != characterSkill.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterSkillExists(id))
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

        // POST: api/CharacterSkills
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterSkill>> PostCharacterSkill(CharacterSkill characterSkill)
        {
            _context.CharacterSkills.Add(characterSkill);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterSkillExists(characterSkill.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterSkill", new { id = characterSkill.CharacterSheetID }, characterSkill);
        }

        // DELETE: api/CharacterSkills/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterSkill>> DeleteCharacterSkill(int id)
        {
            var characterSkill = await _context.CharacterSkills.FindAsync(id);
            if (characterSkill == null)
            {
                return NotFound();
            }

            characterSkill.Deleted = true;
            _context.CharacterSkills.Update(characterSkill);
            await _context.SaveChangesAsync();

            return characterSkill;
        }

        private bool CharacterSkillExists(int id)
        {
            return _context.CharacterSkills.Any(e => e.CharacterSheetID == id);
        }
    }
}
