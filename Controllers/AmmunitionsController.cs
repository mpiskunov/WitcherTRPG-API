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
    public class AmmunitionsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public AmmunitionsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Ammunitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ammunition>>> GetAmmunitions()
        {
            return await _context.Ammunitions.ToListAsync();
        }

        // GET: api/Ammunitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ammunition>> GetAmmunition(int id)
        {
            var ammunition = await _context.Ammunitions.FindAsync(id);

            if (ammunition == null)
            {
                return NotFound();
            }

            return ammunition;
        }

        // PUT: api/Ammunitions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmmunition(int id, Ammunition ammunition)
        {
            if (id != ammunition.ID)
            {
                return BadRequest();
            }

            _context.Entry(ammunition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmmunitionExists(id))
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

        // POST: api/Ammunitions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Ammunition>> PostAmmunition(Ammunition ammunition)
        {
            _context.Ammunitions.Add(ammunition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmmunition", new { id = ammunition.ID }, ammunition);
        }

        // DELETE: api/Ammunitions/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<Ammunition>> DeleteAmmunition(int id)
        {
            var ammunition = await _context.Ammunitions.FindAsync(id);
            if (ammunition == null)
            {
                return NotFound();
            }

            ammunition.Deleted = true;
            _context.Ammunitions.Update(ammunition);
            await _context.SaveChangesAsync();

            return ammunition;
        }

        private bool AmmunitionExists(int id)
        {
            return _context.Ammunitions.Any(e => e.ID == id);
        }
    }
}
