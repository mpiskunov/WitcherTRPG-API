﻿using System;
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
    public class MonstersController : ControllerBase
    {
        private readonly WitcherContext _context;

        public MonstersController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Monsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Monster>>> GetMonsters()
        {
            return await _context.Monsters.ToListAsync();
        }

        // GET: api/Monsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Monster>> GetMonster(int id)
        {
            var monster = await _context.Monsters.FindAsync(id);

            if (monster == null)
            {
                return NotFound();
            }

            return monster;
        }

        // PUT: api/Monsters/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonster(int id, Monster monster)
        {
            if (id != monster.ID)
            {
                return BadRequest();
            }

            _context.Entry(monster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterExists(id))
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

        // POST: api/Monsters
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Monster>> PostMonster(Monster monster)
        {
            _context.Monsters.Add(monster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonster", new { id = monster.ID }, monster);
        }

        // DELETE: api/Monsters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Monster>> DeleteMonster(int id)
        {
            var monster = await _context.Monsters.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }

            _context.Monsters.Remove(monster);
            await _context.SaveChangesAsync();

            return monster;
        }

        private bool MonsterExists(int id)
        {
            return _context.Monsters.Any(e => e.ID == id);
        }
    }
}
