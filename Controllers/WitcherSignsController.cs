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
    public class WitcherSignsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public WitcherSignsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/WitcherSigns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WitcherSign>>> GetWitcherSigns()
        {
            return await _context.WitcherSigns.ToListAsync();
        }

        // GET: api/WitcherSigns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WitcherSign>> GetWitcherSign(int id)
        {
            var witcherSign = await _context.WitcherSigns.FindAsync(id);

            if (witcherSign == null)
            {
                return NotFound();
            }

            return witcherSign;
        }

        // PUT: api/WitcherSigns/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWitcherSign(int id, WitcherSign witcherSign)
        {
            if (id != witcherSign.ID)
            {
                return BadRequest();
            }

            _context.Entry(witcherSign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WitcherSignExists(id))
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

        // POST: api/WitcherSigns
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WitcherSign>> PostWitcherSign(WitcherSign witcherSign)
        {
            _context.WitcherSigns.Add(witcherSign);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWitcherSign", new { id = witcherSign.ID }, witcherSign);
        }

        // DELETE: api/WitcherSigns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WitcherSign>> DeleteWitcherSign(int id)
        {
            var witcherSign = await _context.WitcherSigns.FindAsync(id);
            if (witcherSign == null)
            {
                return NotFound();
            }

            _context.WitcherSigns.Remove(witcherSign);
            await _context.SaveChangesAsync();

            return witcherSign;
        }

        private bool WitcherSignExists(int id)
        {
            return _context.WitcherSigns.Any(e => e.ID == id);
        }
    }
}
