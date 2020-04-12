using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPGWebApplication.Data;
using WitcherTRPG_API.Models;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignCoversController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CampaignCoversController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CampaignCovers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignCover>>> GetCampaignCovers()
        {
            return await _context.CampaignCovers.ToListAsync();
        }

        // GET: api/CampaignCovers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignCover>> GetCampaignCover(int id)
        {
            var campaignCover = await _context.CampaignCovers.FindAsync(id);

            if (campaignCover == null)
            {
                return NotFound();
            }

            return campaignCover;
        }

        // PUT: api/CampaignCovers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaignCover(int id, CampaignCover campaignCover)
        {
            if (id != campaignCover.ID)
            {
                return BadRequest();
            }

            _context.Entry(campaignCover).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignCoverExists(id))
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

        // POST: api/CampaignCovers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CampaignCover>> PostCampaignCover(CampaignCover campaignCover)
        {
            _context.CampaignCovers.Add(campaignCover);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampaignCover", new { id = campaignCover.ID }, campaignCover);
        }

        // DELETE: api/CampaignCovers/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CampaignCover>> DeleteCampaignCover(int id)
        {
            var campaignCover = await _context.CampaignCovers.FindAsync(id);
            if (campaignCover == null)
            {
                return NotFound();
            }

            campaignCover.Deleted = true;
            _context.CampaignCovers.Update(campaignCover);
            await _context.SaveChangesAsync();

            return campaignCover;
        }

        private bool CampaignCoverExists(int id)
        {
            return _context.CampaignCovers.Any(e => e.ID == id);
        }
    }
}
