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
    public class CharacterWeaponsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterWeaponsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterWeapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterWeapon>>> GetCharacterWeapons()
        {
            return await _context.CharacterWeapons.ToListAsync();
        }

        // GET: api/CharacterWeapons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterWeapon>> GetCharacterWeapon(int id)
        {
            var characterWeapon = await _context.CharacterWeapons.FindAsync(id);

            if (characterWeapon == null)
            {
                return NotFound();
            }

            return characterWeapon;
        }

        // PUT: api/CharacterWeapons/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterWeapon(int id, CharacterWeapon characterWeapon)
        {
            if (id != characterWeapon.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterWeapon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterWeaponExists(id))
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

        // POST: api/CharacterWeapons
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterWeapon>> PostCharacterWeapon(CharacterWeapon characterWeapon)
        {
            _context.CharacterWeapons.Add(characterWeapon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterWeapon", new { id = characterWeapon.ID }, characterWeapon);
        }

        // DELETE: api/CharacterWeapons/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterWeapon>> DeleteCharacterWeapon(int id)
        {
            var characterWeapon = await _context.CharacterWeapons.FindAsync(id);
            if (characterWeapon == null)
            {
                return NotFound();
            }

            characterWeapon.Deleted = true;
            _context.CharacterWeapons.Update(characterWeapon);
            await _context.SaveChangesAsync();

            return characterWeapon;
        }

        private bool CharacterWeaponExists(int id)
        {
            return _context.CharacterWeapons.Any(e => e.ID == id);
        }
    }
}
