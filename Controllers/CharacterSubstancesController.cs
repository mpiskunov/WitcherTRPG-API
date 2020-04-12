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
    public class CharacterSubstancesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterSubstancesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSubstances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSubstance>>> GetCharacterSubstances()
        {
            return await _context.CharacterSubstances.ToListAsync();
        }

        // GET: api/CharacterSubstances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSubstance>> GetCharacterSubstance(int id)
        {
            var characterSubstance = await _context.CharacterSubstances.FindAsync(id);

            if (characterSubstance == null)
            {
                return NotFound();
            }

            return characterSubstance;
        }

        // PUT: api/CharacterSubstances/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterSubstance(int id, CharacterSubstance characterSubstance)
        {
            if (id != characterSubstance.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterSubstance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterSubstanceExists(id))
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

        // POST: api/CharacterSubstances
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterSubstance>> PostCharacterSubstance(CharacterSubstance characterSubstance)
        {
            _context.CharacterSubstances.Add(characterSubstance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterSubstanceExists(characterSubstance.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterSubstance", new { id = characterSubstance.CharacterSheetID }, characterSubstance);
        }

        // DELETE: api/CharacterSubstances/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterSubstance>> DeleteCharacterSubstance(int id)
        {
            var characterSubstance = await _context.CharacterSubstances.FindAsync(id);
            if (characterSubstance == null)
            {
                return NotFound();
            }

            characterSubstance.Deleted = true;
            _context.CharacterSubstances.Update(characterSubstance);
            await _context.SaveChangesAsync();

            return characterSubstance;
        }

        private bool CharacterSubstanceExists(int id)
        {
            return _context.CharacterSubstances.Any(e => e.CharacterSheetID == id);
        }
    }
}
