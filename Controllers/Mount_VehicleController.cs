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
    public class Mount_VehicleController : ControllerBase
    {
        private readonly WitcherContext _context;

        public Mount_VehicleController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Mount_Vehicle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mount_Vehicle>>> GetMount_Vehicles()
        {
            return await _context.Mount_Vehicles.ToListAsync();
        }

        // GET: api/Mount_Vehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mount_Vehicle>> GetMount_Vehicle(int id)
        {
            var mount_Vehicle = await _context.Mount_Vehicles.FindAsync(id);

            if (mount_Vehicle == null)
            {
                return NotFound();
            }

            return mount_Vehicle;
        }

        // PUT: api/Mount_Vehicle/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMount_Vehicle(int id, Mount_Vehicle mount_Vehicle)
        {
            if (id != mount_Vehicle.ID)
            {
                return BadRequest();
            }

            _context.Entry(mount_Vehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Mount_VehicleExists(id))
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

        // POST: api/Mount_Vehicle
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Mount_Vehicle>> PostMount_Vehicle(Mount_Vehicle mount_Vehicle)
        {
            _context.Mount_Vehicles.Add(mount_Vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMount_Vehicle", new { id = mount_Vehicle.ID }, mount_Vehicle);
        }

        // DELETE: api/Mount_Vehicle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mount_Vehicle>> DeleteMount_Vehicle(int id)
        {
            var mount_Vehicle = await _context.Mount_Vehicles.FindAsync(id);
            if (mount_Vehicle == null)
            {
                return NotFound();
            }

            _context.Mount_Vehicles.Remove(mount_Vehicle);
            await _context.SaveChangesAsync();

            return mount_Vehicle;
        }

        private bool Mount_VehicleExists(int id)
        {
            return _context.Mount_Vehicles.Any(e => e.ID == id);
        }
    }
}
