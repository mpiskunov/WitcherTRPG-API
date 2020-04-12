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
    public class PlacesOfPowersController : ControllerBase
    {
        private readonly WitcherContext _context;

        public PlacesOfPowersController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/PlacesOfPowers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlacesOfPower>>> GetPlacesOfPowers()
        {
            return await _context.PlacesOfPowers.ToListAsync();
        }

        // GET: api/PlacesOfPowers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlacesOfPower>> GetPlacesOfPower(int id)
        {
            var placesOfPower = await _context.PlacesOfPowers.FindAsync(id);

            if (placesOfPower == null)
            {
                return NotFound();
            }

            return placesOfPower;
        }

        // PUT: api/PlacesOfPowers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlacesOfPower(int id, PlacesOfPower placesOfPower)
        {
            if (id != placesOfPower.ID)
            {
                return BadRequest();
            }

            _context.Entry(placesOfPower).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlacesOfPowerExists(id))
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

        // POST: api/PlacesOfPowers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PlacesOfPower>> PostPlacesOfPower(PlacesOfPower placesOfPower)
        {
            _context.PlacesOfPowers.Add(placesOfPower);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlacesOfPower", new { id = placesOfPower.ID }, placesOfPower);
        }

        // DELETE: api/PlacesOfPowers/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<PlacesOfPower>> DeletePlacesOfPower(int id)
        {
            var placesOfPower = await _context.PlacesOfPowers.FindAsync(id);
            if (placesOfPower == null)
            {
                return NotFound();
            }

            placesOfPower.Deleted = true;
            _context.PlacesOfPowers.Update(placesOfPower);
            await _context.SaveChangesAsync();

            return placesOfPower;
        }

        private bool PlacesOfPowerExists(int id)
        {
            return _context.PlacesOfPowers.Any(e => e.ID == id);
        }
    }
}
