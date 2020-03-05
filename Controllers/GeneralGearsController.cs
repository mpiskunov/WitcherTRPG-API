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
    public class GeneralGearsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public GeneralGearsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/GeneralGears
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneralGear>>> GetGeneralGears()
        {
            return await _context.GeneralGears.ToListAsync();
        }

        // GET: api/GeneralGears/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralGear>> GetGeneralGear(int id)
        {
            var generalGear = await _context.GeneralGears.FindAsync(id);

            if (generalGear == null)
            {
                return NotFound();
            }

            return generalGear;
        }

        // PUT: api/GeneralGears/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneralGear(int id, GeneralGear generalGear)
        {
            if (id != generalGear.ID)
            {
                return BadRequest();
            }

            _context.Entry(generalGear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneralGearExists(id))
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

        // POST: api/GeneralGears
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<GeneralGear>> PostGeneralGear(GeneralGear generalGear)
        {
            _context.GeneralGears.Add(generalGear);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneralGear", new { id = generalGear.ID }, generalGear);
        }

        // DELETE: api/GeneralGears/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GeneralGear>> DeleteGeneralGear(int id)
        {
            var generalGear = await _context.GeneralGears.FindAsync(id);
            if (generalGear == null)
            {
                return NotFound();
            }

            _context.GeneralGears.Remove(generalGear);
            await _context.SaveChangesAsync();

            return generalGear;
        }

        private bool GeneralGearExists(int id)
        {
            return _context.GeneralGears.Any(e => e.ID == id);
        }
    }
}
