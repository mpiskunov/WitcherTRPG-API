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
    public class FormulaeController : ControllerBase
    {
        private readonly WitcherContext _context;

        public FormulaeController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Formulae
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Formulae>>> GetFormulaes()
        {
            return await _context.Formulaes.ToListAsync();
        }

        // GET: api/Formulae/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Formulae>> GetFormulae(int id)
        {
            var formulae = await _context.Formulaes.FindAsync(id);

            if (formulae == null)
            {
                return NotFound();
            }

            return formulae;
        }

        // PUT: api/Formulae/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormulae(int id, Formulae formulae)
        {
            if (id != formulae.ID)
            {
                return BadRequest();
            }

            _context.Entry(formulae).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormulaeExists(id))
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

        // POST: api/Formulae
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Formulae>> PostFormulae(Formulae formulae)
        {
            _context.Formulaes.Add(formulae);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFormulae", new { id = formulae.ID }, formulae);
        }

        // DELETE: api/Formulae/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Formulae>> DeleteFormulae(int id)
        {
            var formulae = await _context.Formulaes.FindAsync(id);
            if (formulae == null)
            {
                return NotFound();
            }

            _context.Formulaes.Remove(formulae);
            await _context.SaveChangesAsync();

            return formulae;
        }

        private bool FormulaeExists(int id)
        {
            return _context.Formulaes.Any(e => e.ID == id);
        }
    }
}
