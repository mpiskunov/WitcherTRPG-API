using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPGWebApplication.Data;
using WitcherTRPG_API.Models;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterDerivedStatisticsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterDerivedStatisticsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterDerivedStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterDerivedStatistic>>> GetCharacterDerivedStatistics()
        {
            return await _context.CharacterDerivedStatistics.ToListAsync();
        }

        // GET: api/CharacterDerivedStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDerivedStatistic>> GetCharacterDerivedStatistic(int id)
        {
            var characterDerivedStatistic = await _context.CharacterDerivedStatistics.FindAsync(id);

            if (characterDerivedStatistic == null)
            {
                return NotFound();
            }

            return characterDerivedStatistic;
        }

        // PUT: api/CharacterDerivedStatistics/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterDerivedStatistic(int id, CharacterDerivedStatistic characterDerivedStatistic)
        {
            if (id != characterDerivedStatistic.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterDerivedStatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterDerivedStatisticExists(id))
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

        // POST: api/CharacterDerivedStatistics
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterDerivedStatistic>> PostCharacterDerivedStatistic(CharacterDerivedStatistic characterDerivedStatistic)
        {
            _context.CharacterDerivedStatistics.Add(characterDerivedStatistic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterDerivedStatisticExists(characterDerivedStatistic.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterDerivedStatistic", new { id = characterDerivedStatistic.CharacterSheetID }, characterDerivedStatistic);
        }

        // DELETE: api/CharacterDerivedStatistics/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CharacterDerivedStatistic>> DeleteCharacterDerivedStatistic(int id)
        {
            var characterDerivedStatistic = await _context.CharacterDerivedStatistics.FindAsync(id);
            if (characterDerivedStatistic == null)
            {
                return NotFound();
            }

            characterDerivedStatistic.Deleted = true;
            _context.CharacterDerivedStatistics.Update(characterDerivedStatistic);
            await _context.SaveChangesAsync();

            return characterDerivedStatistic;
        }

        private bool CharacterDerivedStatisticExists(int id)
        {
            return _context.CharacterDerivedStatistics.Any(e => e.CharacterSheetID == id);
        }
    }
}
