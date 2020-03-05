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
    public class DefiningSkillLinksController : ControllerBase
    {
        private readonly WitcherContext _context;

        public DefiningSkillLinksController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/DefiningSkillLinks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DefiningSkillLink>>> GetDefiningSkillLinks()
        {
            return await _context.DefiningSkillLinks.ToListAsync();
        }

        // GET: api/DefiningSkillLinks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DefiningSkillLink>> GetDefiningSkillLink(int id)
        {
            var definingSkillLink = await _context.DefiningSkillLinks.FindAsync(id);

            if (definingSkillLink == null)
            {
                return NotFound();
            }

            return definingSkillLink;
        }

        // PUT: api/DefiningSkillLinks/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDefiningSkillLink(int id, DefiningSkillLink definingSkillLink)
        {
            if (id != definingSkillLink.ID)
            {
                return BadRequest();
            }

            _context.Entry(definingSkillLink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DefiningSkillLinkExists(id))
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

        // POST: api/DefiningSkillLinks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DefiningSkillLink>> PostDefiningSkillLink(DefiningSkillLink definingSkillLink)
        {
            _context.DefiningSkillLinks.Add(definingSkillLink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDefiningSkillLink", new { id = definingSkillLink.ID }, definingSkillLink);
        }

        // DELETE: api/DefiningSkillLinks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DefiningSkillLink>> DeleteDefiningSkillLink(int id)
        {
            var definingSkillLink = await _context.DefiningSkillLinks.FindAsync(id);
            if (definingSkillLink == null)
            {
                return NotFound();
            }

            _context.DefiningSkillLinks.Remove(definingSkillLink);
            await _context.SaveChangesAsync();

            return definingSkillLink;
        }

        private bool DefiningSkillLinkExists(int id)
        {
            return _context.DefiningSkillLinks.Any(e => e.ID == id);
        }
    }
}
