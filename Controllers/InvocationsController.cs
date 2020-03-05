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
    public class InvocationsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public InvocationsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Invocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invocation>>> GetInvocations()
        {
            return await _context.Invocations.ToListAsync();
        }

        // GET: api/Invocations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invocation>> GetInvocation(int id)
        {
            var invocation = await _context.Invocations.FindAsync(id);

            if (invocation == null)
            {
                return NotFound();
            }

            return invocation;
        }

        // PUT: api/Invocations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvocation(int id, Invocation invocation)
        {
            if (id != invocation.ID)
            {
                return BadRequest();
            }

            _context.Entry(invocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvocationExists(id))
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

        // POST: api/Invocations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Invocation>> PostInvocation(Invocation invocation)
        {
            _context.Invocations.Add(invocation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvocation", new { id = invocation.ID }, invocation);
        }

        // DELETE: api/Invocations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Invocation>> DeleteInvocation(int id)
        {
            var invocation = await _context.Invocations.FindAsync(id);
            if (invocation == null)
            {
                return NotFound();
            }

            _context.Invocations.Remove(invocation);
            await _context.SaveChangesAsync();

            return invocation;
        }

        private bool InvocationExists(int id)
        {
            return _context.Invocations.Any(e => e.ID == id);
        }
    }
}
