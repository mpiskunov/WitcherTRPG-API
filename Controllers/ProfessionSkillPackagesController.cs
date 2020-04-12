using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WitcherTRPG_API.Models;
using WitcherTRPGWebApplication.Data;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionSkillPackagesController : ControllerBase
    {
        private readonly WitcherContext _context;

        public ProfessionSkillPackagesController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/ProfessionSkillPackages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessionSkillPackage>>> GetSkillPackages()
        {
            return await _context.SkillPackages.ToListAsync();
        }

        // GET: api/ProfessionSkillPackages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessionSkillPackage>> GetProfessionSkillPackage(int id)
        {
            var professionSkillPackage = await _context.SkillPackages.FindAsync(id);

            if (professionSkillPackage == null)
            {
                return NotFound();
            }

            return professionSkillPackage;
        }

        // PUT: api/ProfessionSkillPackages/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessionSkillPackage(int id, ProfessionSkillPackage professionSkillPackage)
        {
            if (id != professionSkillPackage.ProfessionID)
            {
                return BadRequest();
            }

            _context.Entry(professionSkillPackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionSkillPackageExists(id))
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

        // POST: api/ProfessionSkillPackages
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ProfessionSkillPackage>> PostProfessionSkillPackage(ProfessionSkillPackage professionSkillPackage)
        {
            _context.SkillPackages.Add(professionSkillPackage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProfessionSkillPackageExists(professionSkillPackage.ProfessionID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProfessionSkillPackage", new { id = professionSkillPackage.ProfessionID }, professionSkillPackage);
        }

        // DELETE: api/ProfessionSkillPackages/5
        [HttpPut("[action]/{id}")]
        public async Task<ActionResult<ProfessionSkillPackage>> DeleteProfessionSkillPackage(int id)
        {
            var professionSkillPackage = await _context.SkillPackages.FindAsync(id);
            if (professionSkillPackage == null)
            {
                return NotFound();
            }

            professionSkillPackage.Deleted = true;
            _context.SkillPackages.Update(professionSkillPackage);
            await _context.SaveChangesAsync();

            return professionSkillPackage;
        }

        private bool ProfessionSkillPackageExists(int id)
        {
            return _context.SkillPackages.Any(e => e.ProfessionID == id);
        }
    }
}
