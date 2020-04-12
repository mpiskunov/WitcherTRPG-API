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
    public class CharacterLifeEventsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterLifeEventsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterLifeEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterLifeEvent>>> GetCharacterLifeEvents()
        {
            return await _context.CharacterLifeEvents.ToListAsync();
        }

        // GET: api/CharacterLifeEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterLifeEvent>> GetCharacterLifeEvent(int id)
        {
            var characterLifeEvent = await _context.CharacterLifeEvents.FindAsync(id);

            if (characterLifeEvent == null)
            {
                return NotFound();
            }

            return characterLifeEvent;
        }

        // PUT: api/CharacterLifeEvents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterLifeEvent(int id, CharacterLifeEvent characterLifeEvent)
        {
            if (id != characterLifeEvent.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterLifeEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterLifeEventExists(id))
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

        // POST: api/CharacterLifeEvents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterLifeEvent>> PostCharacterLifeEvent(CharacterLifeEvent characterLifeEvent)
        {
            _context.CharacterLifeEvents.Add(characterLifeEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterLifeEvent", new { id = characterLifeEvent.ID }, characterLifeEvent);
        }

        // DELETE: api/CharacterLifeEvents/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterLifeEvent>> DeleteCharacterLifeEvent(int id)
        {
            var characterLifeEvent = await _context.CharacterLifeEvents.FindAsync(id);
            if (characterLifeEvent == null)
            {
                return NotFound();
            }

            characterLifeEvent.Deleted = true;
            _context.CharacterLifeEvents.Update(characterLifeEvent);
            await _context.SaveChangesAsync();

            return characterLifeEvent;
        }

        private bool CharacterLifeEventExists(int id)
        {
            return _context.CharacterLifeEvents.Any(e => e.ID == id);
        }
    }
}
