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
    public class CharacterArmorsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterArmorsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterArmors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterArmor>>> GetCharacterArmors()
        {
            return await _context.CharacterArmors.ToListAsync();
        }

        // GET: api/CharacterArmors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterArmor>> GetCharacterArmor(int id)
        {
            var characterArmor = await _context.CharacterArmors.FindAsync(id);

            if (characterArmor == null)
            {
                return NotFound();
            }

            return characterArmor;
        }

        // PUT: api/CharacterArmors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterArmor(int id, CharacterArmor characterArmor)
        {
            if (id != characterArmor.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterArmor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterArmorExists(id))
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

        // POST: api/CharacterArmors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterArmor>> PostCharacterArmor(CharacterArmor characterArmor)
        {
            _context.CharacterArmors.Add(characterArmor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterArmor", new { id = characterArmor.ID }, characterArmor);
        }

        // DELETE: api/CharacterArmors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterArmor>> DeleteCharacterArmor(int id)
        {
            var characterArmor = await _context.CharacterArmors.FindAsync(id);
            if (characterArmor == null)
            {
                return NotFound();
            }

            _context.CharacterArmors.Remove(characterArmor);
            await _context.SaveChangesAsync();

            return characterArmor;
        }

        private bool CharacterArmorExists(int id)
        {
            return _context.CharacterArmors.Any(e => e.ID == id);
        }
    }
}
