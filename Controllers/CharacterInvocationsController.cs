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
    public class CharacterInvocationsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterInvocationsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterInvocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterInvocation>>> GetCharacterInvocations()
        {
            return await _context.CharacterInvocations.ToListAsync();
        }

        // GET: api/CharacterInvocations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterInvocation>> GetCharacterInvocation(int id)
        {
            var characterInvocation = await _context.CharacterInvocations.FindAsync(id);

            if (characterInvocation == null)
            {
                return NotFound();
            }

            return characterInvocation;
        }

        // PUT: api/CharacterInvocations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterInvocation(int id, CharacterInvocation characterInvocation)
        {
            if (id != characterInvocation.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterInvocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterInvocationExists(id))
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

        // POST: api/CharacterInvocations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterInvocation>> PostCharacterInvocation(CharacterInvocation characterInvocation)
        {
            _context.CharacterInvocations.Add(characterInvocation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterInvocationExists(characterInvocation.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterInvocation", new { id = characterInvocation.CharacterSheetID }, characterInvocation);
        }

        // DELETE: api/CharacterInvocations/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterInvocation>> DeleteCharacterInvocation(int id)
        {
            var characterInvocation = await _context.CharacterInvocations.FindAsync(id);
            if (characterInvocation == null)
            {
                return NotFound();
            }

            characterInvocation.Deleted = true;
            _context.CharacterInvocations.Update(characterInvocation);
            await _context.SaveChangesAsync();

            return characterInvocation;
        }

        private bool CharacterInvocationExists(int id)
        {
            return _context.CharacterInvocations.Any(e => e.CharacterSheetID == id);
        }
    }
}
