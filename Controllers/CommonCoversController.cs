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
    public class CommonCoversController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CommonCoversController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CommonCovers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommonCover>>> GetCommonCovers()
        {
            return await _context.CommonCovers.ToListAsync();
        }

        // GET: api/CommonCovers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommonCover>> GetCommonCover(int id)
        {
            var commonCover = await _context.CommonCovers.FindAsync(id);

            if (commonCover == null)
            {
                return NotFound();
            }

            return commonCover;
        }

        // PUT: api/CommonCovers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommonCover(int id, CommonCover commonCover)
        {
            if (id != commonCover.ID)
            {
                return BadRequest();
            }

            _context.Entry(commonCover).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommonCoverExists(id))
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

        // POST: api/CommonCovers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CommonCover>> PostCommonCover(CommonCover commonCover)
        {
            _context.CommonCovers.Add(commonCover);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommonCover", new { id = commonCover.ID }, commonCover);
        }

        // DELETE: api/CommonCovers/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CommonCover>> DeleteCommonCover(int id)
        {
            var commonCover = await _context.CommonCovers.FindAsync(id);
            if (commonCover == null)
            {
                return NotFound();
            }

            commonCover.Deleted = true;
            _context.CommonCovers.Update(commonCover);
            await _context.SaveChangesAsync();

            return commonCover;
        }

        private bool CommonCoverExists(int id)
        {
            return _context.CommonCovers.Any(e => e.ID == id);
        }
    }
}
