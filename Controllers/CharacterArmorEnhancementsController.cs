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
    public class CharacterArmorEnhancementsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterArmorEnhancementsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterArmorEnhancements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterArmorEnhancement>>> GetCharacterArmorEnhancements()
        {
            return await _context.CharacterArmorEnhancements.ToListAsync();
        }

        // GET: api/CharacterArmorEnhancements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterArmorEnhancement>> GetCharacterArmorEnhancement(int id)
        {
            var characterArmorEnhancement = await _context.CharacterArmorEnhancements.FindAsync(id);

            if (characterArmorEnhancement == null)
            {
                return NotFound();
            }

            return characterArmorEnhancement;
        }

        // PUT: api/CharacterArmorEnhancements/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterArmorEnhancement(int id, CharacterArmorEnhancement characterArmorEnhancement)
        {
            if (id != characterArmorEnhancement.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterArmorEnhancement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterArmorEnhancementExists(id))
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

        // POST: api/CharacterArmorEnhancements
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterArmorEnhancement>> PostCharacterArmorEnhancement(CharacterArmorEnhancement characterArmorEnhancement)
        {
            _context.CharacterArmorEnhancements.Add(characterArmorEnhancement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterArmorEnhancement", new { id = characterArmorEnhancement.ID }, characterArmorEnhancement);
        }

        // DELETE: api/CharacterArmorEnhancements/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterArmorEnhancement>> DeleteCharacterArmorEnhancement(int id)
        {
            var characterArmorEnhancement = await _context.CharacterArmorEnhancements.FindAsync(id);
            if (characterArmorEnhancement == null)
            {
                return NotFound();
            }

            characterArmorEnhancement.Deleted = true;
            _context.CharacterArmorEnhancements.Update(characterArmorEnhancement);
            await _context.SaveChangesAsync();

            return characterArmorEnhancement;
        }

        private bool CharacterArmorEnhancementExists(int id)
        {
            return _context.CharacterArmorEnhancements.Any(e => e.ID == id);
        }
    }
}
