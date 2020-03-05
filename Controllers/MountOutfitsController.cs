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
    public class MountOutfitsController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MountOutfitsController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/MountOutfits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MountOutfit>>> GetMountOutfits()
        {
            return await _context.MountOutfits.ToListAsync();
        }

        // GET: api/MountOutfits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MountOutfit>> GetMountOutfit(int id)
        {
            var mountOutfit = await _context.MountOutfits.FindAsync(id);

            if (mountOutfit == null)
            {
                return NotFound();
            }

            return mountOutfit;
        }

        // PUT: api/MountOutfits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMountOutfit(int id, MountOutfit mountOutfit)
        {
            if (id != mountOutfit.ID)
            {
                return BadRequest();
            }

            _context.Entry(mountOutfit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MountOutfitExists(id))
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

        // POST: api/MountOutfits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MountOutfit>> PostMountOutfit(MountOutfit mountOutfit)
        {
            _context.MountOutfits.Add(mountOutfit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMountOutfit", new { id = mountOutfit.ID }, mountOutfit);
        }

        // DELETE: api/MountOutfits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MountOutfit>> DeleteMountOutfit(int id)
        {
            var mountOutfit = await _context.MountOutfits.FindAsync(id);
            if (mountOutfit == null)
            {
                return NotFound();
            }

            _context.MountOutfits.Remove(mountOutfit);
            await _context.SaveChangesAsync();

            return mountOutfit;
        }

        private bool MountOutfitExists(int id)
        {
            return _context.MountOutfits.Any(e => e.ID == id);
        }
    }
}
