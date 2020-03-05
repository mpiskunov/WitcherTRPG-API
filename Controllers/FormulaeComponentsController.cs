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
    public class FormulaeComponentsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public FormulaeComponentsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/FormulaeComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormulaeComponent>>> GetFormulaeComponents()
        {
            return await _context.FormulaeComponents.ToListAsync();
        }

        // GET: api/FormulaeComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormulaeComponent>> GetFormulaeComponent(int id)
        {
            var formulaeComponent = await _context.FormulaeComponents.FindAsync(id);

            if (formulaeComponent == null)
            {
                return NotFound();
            }

            return formulaeComponent;
        }

        // PUT: api/FormulaeComponents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormulaeComponent(int id, FormulaeComponent formulaeComponent)
        {
            if (id != formulaeComponent.ID)
            {
                return BadRequest();
            }

            _context.Entry(formulaeComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormulaeComponentExists(id))
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

        // POST: api/FormulaeComponents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<FormulaeComponent>> PostFormulaeComponent(FormulaeComponent formulaeComponent)
        {
            _context.FormulaeComponents.Add(formulaeComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFormulaeComponent", new { id = formulaeComponent.ID }, formulaeComponent);
        }

        // DELETE: api/FormulaeComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FormulaeComponent>> DeleteFormulaeComponent(int id)
        {
            var formulaeComponent = await _context.FormulaeComponents.FindAsync(id);
            if (formulaeComponent == null)
            {
                return NotFound();
            }

            _context.FormulaeComponents.Remove(formulaeComponent);
            await _context.SaveChangesAsync();

            return formulaeComponent;
        }

        private bool FormulaeComponentExists(int id)
        {
            return _context.FormulaeComponents.Any(e => e.ID == id);
        }
    }
}
