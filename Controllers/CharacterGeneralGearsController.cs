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
    public class CharacterGeneralGearsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterGeneralGearsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterGeneralGears
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterGeneralGear>>> GetCharacterGeneralGears()
        {
            return await _context.CharacterGeneralGears.ToListAsync();
        }

        // GET: api/CharacterGeneralGears/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterGeneralGear>> GetCharacterGeneralGear(int id)
        {
            var characterGeneralGear = await _context.CharacterGeneralGears.FindAsync(id);

            if (characterGeneralGear == null)
            {
                return NotFound();
            }

            return characterGeneralGear;
        }

        // PUT: api/CharacterGeneralGears/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterGeneralGear(int id, CharacterGeneralGear characterGeneralGear)
        {
            if (id != characterGeneralGear.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterGeneralGear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterGeneralGearExists(id))
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

        // POST: api/CharacterGeneralGears
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterGeneralGear>> PostCharacterGeneralGear(CharacterGeneralGear characterGeneralGear)
        {
            _context.CharacterGeneralGears.Add(characterGeneralGear);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterGeneralGearExists(characterGeneralGear.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterGeneralGear", new { id = characterGeneralGear.CharacterSheetID }, characterGeneralGear);
        }

        // DELETE: api/CharacterGeneralGears/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterGeneralGear>> DeleteCharacterGeneralGear(int id)
        {
            var characterGeneralGear = await _context.CharacterGeneralGears.FindAsync(id);
            if (characterGeneralGear == null)
            {
                return NotFound();
            }

            characterGeneralGear.Deleted = true;
            _context.CharacterGeneralGears.Update(characterGeneralGear);
            await _context.SaveChangesAsync();

            return characterGeneralGear;
        }

        private bool CharacterGeneralGearExists(int id)
        {
            return _context.CharacterGeneralGears.Any(e => e.CharacterSheetID == id);
        }
    }
}
