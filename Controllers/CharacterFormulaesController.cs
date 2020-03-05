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
    public class CharacterFormulaesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterFormulaesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterFormulaes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterFormulae>>> GetCharacterFormulaes()
        {
            return await _context.CharacterFormulaes.ToListAsync();
        }

        // GET: api/CharacterFormulaes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterFormulae>> GetCharacterFormulae(int id)
        {
            var characterFormulae = await _context.CharacterFormulaes.FindAsync(id);

            if (characterFormulae == null)
            {
                return NotFound();
            }

            return characterFormulae;
        }

        // PUT: api/CharacterFormulaes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterFormulae(int id, CharacterFormulae characterFormulae)
        {
            if (id != characterFormulae.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterFormulae).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterFormulaeExists(id))
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

        // POST: api/CharacterFormulaes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterFormulae>> PostCharacterFormulae(CharacterFormulae characterFormulae)
        {
            _context.CharacterFormulaes.Add(characterFormulae);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterFormulaeExists(characterFormulae.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterFormulae", new { id = characterFormulae.CharacterSheetID }, characterFormulae);
        }

        // DELETE: api/CharacterFormulaes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterFormulae>> DeleteCharacterFormulae(int id)
        {
            var characterFormulae = await _context.CharacterFormulaes.FindAsync(id);
            if (characterFormulae == null)
            {
                return NotFound();
            }

            _context.CharacterFormulaes.Remove(characterFormulae);
            await _context.SaveChangesAsync();

            return characterFormulae;
        }

        private bool CharacterFormulaeExists(int id)
        {
            return _context.CharacterFormulaes.Any(e => e.CharacterSheetID == id);
        }
    }
}
