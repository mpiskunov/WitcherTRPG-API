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
    public class CampaignNotesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public CampaignNotesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/CampaignNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampaignNote>>> GetCampaignNotes()
        {
            return await _context.CampaignNotes.ToListAsync();
        }

        // GET: api/CampaignNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignNote>> GetCampaignNote(int id)
        {
            var campaignNote = await _context.CampaignNotes.FindAsync(id);

            if (campaignNote == null)
            {
                return NotFound();
            }

            return campaignNote;
        }

        // PUT: api/CampaignNotes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaignNote(int id, CampaignNote campaignNote)
        {
            if (id != campaignNote.ID)
            {
                return BadRequest();
            }

            _context.Entry(campaignNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignNoteExists(id))
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

        // POST: api/CampaignNotes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CampaignNote>> PostCampaignNote(CampaignNote campaignNote)
        {
            _context.CampaignNotes.Add(campaignNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampaignNote", new { id = campaignNote.ID }, campaignNote);
        }

        // DELETE: api/CampaignNotes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CampaignNote>> DeleteCampaignNote(int id)
        {
            var campaignNote = await _context.CampaignNotes.FindAsync(id);
            if (campaignNote == null)
            {
                return NotFound();
            }

            _context.CampaignNotes.Remove(campaignNote);
            await _context.SaveChangesAsync();

            return campaignNote;
        }

        private bool CampaignNoteExists(int id)
        {
            return _context.CampaignNotes.Any(e => e.ID == id);
        }
    }
}
