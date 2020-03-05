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
    public class CharacterStatisticsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CharacterStatisticsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CharacterStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterStatistic>>> GetCharacterStatistics()
        {
            return await _context.CharacterStatistics.ToListAsync();
        }

        // GET: api/CharacterStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterStatistic>> GetCharacterStatistic(int id)
        {
            var characterStatistic = await _context.CharacterStatistics.FindAsync(id);

            if (characterStatistic == null)
            {
                return NotFound();
            }

            return characterStatistic;
        }

        // PUT: api/CharacterStatistics/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterStatistic(int id, CharacterStatistic characterStatistic)
        {
            if (id != characterStatistic.CharacterSheetID)
            {
                return BadRequest();
            }

            _context.Entry(characterStatistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterStatisticExists(id))
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

        // POST: api/CharacterStatistics
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CharacterStatistic>> PostCharacterStatistic(CharacterStatistic characterStatistic)
        {
            _context.CharacterStatistics.Add(characterStatistic);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterStatisticExists(characterStatistic.CharacterSheetID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterStatistic", new { id = characterStatistic.CharacterSheetID }, characterStatistic);
        }

        // DELETE: api/CharacterStatistics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CharacterStatistic>> DeleteCharacterStatistic(int id)
        {
            var characterStatistic = await _context.CharacterStatistics.FindAsync(id);
            if (characterStatistic == null)
            {
                return NotFound();
            }

            _context.CharacterStatistics.Remove(characterStatistic);
            await _context.SaveChangesAsync();

            return characterStatistic;
        }

        private bool CharacterStatisticExists(int id)
        {
            return _context.CharacterStatistics.Any(e => e.CharacterSheetID == id);
        }
    }
}
