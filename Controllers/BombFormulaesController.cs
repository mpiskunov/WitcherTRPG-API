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
    public class BombFormulaesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public BombFormulaesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/BombFormulaes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BombFormulae>>> GetBombFormulaes()
        {
            return await _context.BombFormulaes.ToListAsync();
        }

        // GET: api/BombFormulaes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BombFormulae>> GetBombFormulae(int id)
        {
            var bombFormulae = await _context.BombFormulaes.FindAsync(id);

            if (bombFormulae == null)
            {
                return NotFound();
            }

            return bombFormulae;
        }

        // PUT: api/BombFormulaes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBombFormulae(int id, BombFormulae bombFormulae)
        {
            if (id != bombFormulae.ID)
            {
                return BadRequest();
            }

            _context.Entry(bombFormulae).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BombFormulaeExists(id))
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

        // POST: api/BombFormulaes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<BombFormulae>> PostBombFormulae(BombFormulae bombFormulae)
        {
            _context.BombFormulaes.Add(bombFormulae);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBombFormulae", new { id = bombFormulae.ID }, bombFormulae);
        }

        // DELETE: api/BombFormulaes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BombFormulae>> DeleteBombFormulae(int id)
        {
            var bombFormulae = await _context.BombFormulaes.FindAsync(id);
            if (bombFormulae == null)
            {
                return NotFound();
            }

            _context.BombFormulaes.Remove(bombFormulae);
            await _context.SaveChangesAsync();

            return bombFormulae;
        }

        private bool BombFormulaeExists(int id)
        {
            return _context.BombFormulaes.Any(e => e.ID == id);
        }
    }
}
