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
    public class CampaignMonstersController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CampaignMonstersController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CampaignMonsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignMonster>>> GetCampaignMonsters()
        {
            return await _context.CampaignMonsters.ToListAsync();
        }

        // GET: api/CampaignMonsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignMonster>> GetCampaignMonster(int id)
        {
            var campaignMonster = await _context.CampaignMonsters.FindAsync(id);

            if (campaignMonster == null)
            {
                return NotFound();
            }

            return campaignMonster;
        }

        // PUT: api/CampaignMonsters/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaignMonster(int id, CampaignMonster campaignMonster)
        {
            if (id != campaignMonster.ID)
            {
                return BadRequest();
            }

            _context.Entry(campaignMonster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignMonsterExists(id))
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

        // POST: api/CampaignMonsters
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CampaignMonster>> PostCampaignMonster(CampaignMonster campaignMonster)
        {
            _context.CampaignMonsters.Add(campaignMonster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampaignMonster", new { id = campaignMonster.ID }, campaignMonster);
        }

        // DELETE: api/CampaignMonsters/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<CampaignMonster>> DeleteCampaignMonster(int id)
        {
            var campaignMonster = await _context.CampaignMonsters.FindAsync(id);
            if (campaignMonster == null)
            {
                return NotFound();
            }

            campaignMonster.Deleted = true;
            _context.CampaignMonsters.Update(campaignMonster);
            await _context.SaveChangesAsync();

            return campaignMonster;
        }

        private bool CampaignMonsterExists(int id)
        {
            return _context.CampaignMonsters.Any(e => e.ID == id);
        }
    }
}
