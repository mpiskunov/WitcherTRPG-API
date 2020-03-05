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
    public class BombFormulaeComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public BombFormulaeComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/BombFormulaeComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BombFormulaeComponent>>> GetBombFormulaeComponents()
        {
            return await _context.BombFormulaeComponents.ToListAsync();
        }

        // GET: api/BombFormulaeComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BombFormulaeComponent>> GetBombFormulaeComponent(int id)
        {
            var bombFormulaeComponent = await _context.BombFormulaeComponents.FindAsync(id);

            if (bombFormulaeComponent == null)
            {
                return NotFound();
            }

            return bombFormulaeComponent;
        }

        // PUT: api/BombFormulaeComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBombFormulaeComponent(int id, BombFormulaeComponent bombFormulaeComponent)
        {
            if (id != bombFormulaeComponent.ID)
            {
                return BadRequest();
            }

            _context.Entry(bombFormulaeComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BombFormulaeComponentExists(id))
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

        // POST: api/BombFormulaeComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<BombFormulaeComponent>> PostBombFormulaeComponent(BombFormulaeComponent bombFormulaeComponent)
        {
            _context.BombFormulaeComponents.Add(bombFormulaeComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBombFormulaeComponent", new { id = bombFormulaeComponent.ID }, bombFormulaeComponent);
        }

        // DELETE: api/BombFormulaeComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BombFormulaeComponent>> DeleteBombFormulaeComponent(int id)
        {
            var bombFormulaeComponent = await _context.BombFormulaeComponents.FindAsync(id);
            if (bombFormulaeComponent == null)
            {
                return NotFound();
            }

            _context.BombFormulaeComponents.Remove(bombFormulaeComponent);
            await _context.SaveChangesAsync();

            return bombFormulaeComponent;
        }

        private bool BombFormulaeComponentExists(int id)
        {
            return _context.BombFormulaeComponents.Any(e => e.ID == id);
        }
    }
}
