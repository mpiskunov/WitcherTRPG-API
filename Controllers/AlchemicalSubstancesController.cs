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
    public class AlchemicalSubstancesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AlchemicalSubstancesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/AlchemicalSubstances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlchemicalSubstance>>> GetAlchemicalSubstances()
        {
            return await _context.AlchemicalSubstances.ToListAsync();
        }

        // GET: api/AlchemicalSubstances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlchemicalSubstance>> GetAlchemicalSubstance(int id)
        {
            var alchemicalSubstance = await _context.AlchemicalSubstances.FindAsync(id);

            if (alchemicalSubstance == null)
            {
                return NotFound();
            }

            return alchemicalSubstance;
        }

        // PUT: api/AlchemicalSubstances/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlchemicalSubstance(int id, AlchemicalSubstance alchemicalSubstance)
        {
            if (id != alchemicalSubstance.ID)
            {
                return BadRequest();
            }

            _context.Entry(alchemicalSubstance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlchemicalSubstanceExists(id))
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

        // POST: api/AlchemicalSubstances
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AlchemicalSubstance>> PostAlchemicalSubstance(AlchemicalSubstance alchemicalSubstance)
        {
            _context.AlchemicalSubstances.Add(alchemicalSubstance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlchemicalSubstance", new { id = alchemicalSubstance.ID }, alchemicalSubstance);
        }

        // DELETE: api/AlchemicalSubstances/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<AlchemicalSubstance>> DeleteAlchemicalSubstance(int id)
        {
            var alchemicalSubstance = await _context.AlchemicalSubstances.FindAsync(id);
            if (alchemicalSubstance == null)
            {
                return NotFound();
            }

            alchemicalSubstance.Deleted = true;
            _context.AlchemicalSubstances.Update(alchemicalSubstance);
            await _context.SaveChangesAsync();

            return alchemicalSubstance;
        }

        private bool AlchemicalSubstanceExists(int id)
        {
            return _context.AlchemicalSubstances.Any(e => e.ID == id);
        }
    }
}
