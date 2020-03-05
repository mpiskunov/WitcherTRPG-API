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
    public class CharacterServicesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterServicesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterService>>> GetCharacterServices()
        {
            return await _context.CharacterServices.ToListAsync();
        }

        // GET: api/CharacterServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterService>> GetCharacterService(int id)
        {
            var characterService = await _context.CharacterServices.FindAsync(id);

            if (characterService == null)
            {
                return NotFound();
            }

            return characterService;
        }

        // PUT: api/CharacterServices/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterService(int id, CharacterService characterService)
        {
            if (id != characterService.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterServiceExists(id))
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

        // POST: api/CharacterServices
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterService>> PostCharacterService(CharacterService characterService)
        {
            _context.CharacterServices.Add(characterService);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterServiceExists(characterService.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterService", new { id = characterService.CharacterSheetID }, characterService);
        }

        // DELETE: api/CharacterServices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterService>> DeleteCharacterService(int id)
        {
            var characterService = await _context.CharacterServices.FindAsync(id);
            if (characterService == null)
            {
                return NotFound();
            }

            _context.CharacterServices.Remove(characterService);
            await _context.SaveChangesAsync();

            return characterService;
        }

        private bool CharacterServiceExists(int id)
        {
            return _context.CharacterServices.Any(e => e.CharacterSheetID == id);
        }
    }
}
