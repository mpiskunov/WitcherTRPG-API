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
    public class CharacterAlchemicalItemsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterAlchemicalItemsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterAlchemicalItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterAlchemicalItem>>> GetCharacterAlchemicalItems()
        {
            return await _context.CharacterAlchemicalItems.ToListAsync();
        }

        // GET: api/CharacterAlchemicalItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterAlchemicalItem>> GetCharacterAlchemicalItem(int id)
        {
            var characterAlchemicalItem = await _context.CharacterAlchemicalItems.FindAsync(id);

            if (characterAlchemicalItem == null)
            {
                return NotFound();
            }

            return characterAlchemicalItem;
        }

        // PUT: api/CharacterAlchemicalItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterAlchemicalItem(int id, CharacterAlchemicalItem characterAlchemicalItem)
        {
            if (id != characterAlchemicalItem.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterAlchemicalItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterAlchemicalItemExists(id))
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

        // POST: api/CharacterAlchemicalItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterAlchemicalItem>> PostCharacterAlchemicalItem(CharacterAlchemicalItem characterAlchemicalItem)
        {
            _context.CharacterAlchemicalItems.Add(characterAlchemicalItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterAlchemicalItemExists(characterAlchemicalItem.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterAlchemicalItem", new { id = characterAlchemicalItem.CharacterSheetID }, characterAlchemicalItem);
        }

        // DELETE: api/CharacterAlchemicalItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterAlchemicalItem>> DeleteCharacterAlchemicalItem(int id)
        {
            var characterAlchemicalItem = await _context.CharacterAlchemicalItems.FindAsync(id);
            if (characterAlchemicalItem == null)
            {
                return NotFound();
            }

            _context.CharacterAlchemicalItems.Remove(characterAlchemicalItem);
            await _context.SaveChangesAsync();

            return characterAlchemicalItem;
        }

        private bool CharacterAlchemicalItemExists(int id)
        {
            return _context.CharacterAlchemicalItems.Any(e => e.CharacterSheetID == id);
        }
    }
}
