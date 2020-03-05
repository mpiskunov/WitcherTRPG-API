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
    public class CharacterMountOutfitsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterMountOutfitsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterMountOutfits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterMountOutfit>>> GetCharacterMountOutfits()
        {
            return await _context.CharacterMountOutfits.ToListAsync();
        }

        // GET: api/CharacterMountOutfits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterMountOutfit>> GetCharacterMountOutfit(int id)
        {
            var characterMountOutfit = await _context.CharacterMountOutfits.FindAsync(id);

            if (characterMountOutfit == null)
            {
                return NotFound();
            }

            return characterMountOutfit;
        }

        // PUT: api/CharacterMountOutfits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterMountOutfit(int id, CharacterMountOutfit characterMountOutfit)
        {
            if (id != characterMountOutfit.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterMountOutfit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterMountOutfitExists(id))
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

        // POST: api/CharacterMountOutfits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterMountOutfit>> PostCharacterMountOutfit(CharacterMountOutfit characterMountOutfit)
        {
            _context.CharacterMountOutfits.Add(characterMountOutfit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterMountOutfit", new { id = characterMountOutfit.ID }, characterMountOutfit);
        }

        // DELETE: api/CharacterMountOutfits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterMountOutfit>> DeleteCharacterMountOutfit(int id)
        {
            var characterMountOutfit = await _context.CharacterMountOutfits.FindAsync(id);
            if (characterMountOutfit == null)
            {
                return NotFound();
            }

            _context.CharacterMountOutfits.Remove(characterMountOutfit);
            await _context.SaveChangesAsync();

            return characterMountOutfit;
        }

        private bool CharacterMountOutfitExists(int id)
        {
            return _context.CharacterMountOutfits.Any(e => e.ID == id);
        }
    }
}
