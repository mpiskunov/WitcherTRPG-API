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
    public class CharacterMount_VehicleController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterMount_VehicleController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterMount_Vehicle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterMount_Vehicle>>> GetCharacterMount_Vehicles()
        {
            return await _context.CharacterMount_Vehicles.ToListAsync();
        }

        // GET: api/CharacterMount_Vehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterMount_Vehicle>> GetCharacterMount_Vehicle(int id)
        {
            var characterMount_Vehicle = await _context.CharacterMount_Vehicles.FindAsync(id);

            if (characterMount_Vehicle == null)
            {
                return NotFound();
            }

            return characterMount_Vehicle;
        }

        // PUT: api/CharacterMount_Vehicle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterMount_Vehicle(int id, CharacterMount_Vehicle characterMount_Vehicle)
        {
            if (id != characterMount_Vehicle.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterMount_Vehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterMount_VehicleExists(id))
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

        // POST: api/CharacterMount_Vehicle
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterMount_Vehicle>> PostCharacterMount_Vehicle(CharacterMount_Vehicle characterMount_Vehicle)
        {
            _context.CharacterMount_Vehicles.Add(characterMount_Vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterMount_Vehicle", new { id = characterMount_Vehicle.ID }, characterMount_Vehicle);
        }

        // DELETE: api/CharacterMount_Vehicle/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterMount_Vehicle>> DeleteCharacterMount_Vehicle(int id)
        {
            var characterMount_Vehicle = await _context.CharacterMount_Vehicles.FindAsync(id);
            if (characterMount_Vehicle == null)
            {
                return NotFound();
            }

            characterMount_Vehicle.Deleted = true;
            _context.CharacterMount_Vehicles.Update(characterMount_Vehicle);
            await _context.SaveChangesAsync();

            return characterMount_Vehicle;
        }

        private bool CharacterMount_VehicleExists(int id)
        {
            return _context.CharacterMount_Vehicles.Any(e => e.ID == id);
        }
    }
}
