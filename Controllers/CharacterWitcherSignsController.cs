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
    public class CharacterWitcherSignsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterWitcherSignsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterWitcherSigns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterWitcherSign>>> GetCharacterWitcherSigns()
        {
            return await _context.CharacterWitcherSigns.ToListAsync();
        }

        // GET: api/CharacterWitcherSigns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterWitcherSign>> GetCharacterWitcherSign(int id)
        {
            var characterWitcherSign = await _context.CharacterWitcherSigns.FindAsync(id);

            if (characterWitcherSign == null)
            {
                return NotFound();
            }

            return characterWitcherSign;
        }

        // PUT: api/CharacterWitcherSigns/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterWitcherSign(int id, CharacterWitcherSign characterWitcherSign)
        {
            if (id != characterWitcherSign.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterWitcherSign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterWitcherSignExists(id))
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

        // POST: api/CharacterWitcherSigns
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterWitcherSign>> PostCharacterWitcherSign(CharacterWitcherSign characterWitcherSign)
        {
            _context.CharacterWitcherSigns.Add(characterWitcherSign);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterWitcherSignExists(characterWitcherSign.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterWitcherSign", new { id = characterWitcherSign.CharacterSheetID }, characterWitcherSign);
        }

        // DELETE: api/CharacterWitcherSigns/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterWitcherSign>> DeleteCharacterWitcherSign(int id)
        {
            var characterWitcherSign = await _context.CharacterWitcherSigns.FindAsync(id);
            if (characterWitcherSign == null)
            {
                return NotFound();
            }

            characterWitcherSign.Deleted = true;
            _context.CharacterWitcherSigns.Update(characterWitcherSign);
            await _context.SaveChangesAsync();

            return characterWitcherSign;
        }

        private bool CharacterWitcherSignExists(int id)
        {
            return _context.CharacterWitcherSigns.Any(e => e.CharacterSheetID == id);
        }
    }
}
