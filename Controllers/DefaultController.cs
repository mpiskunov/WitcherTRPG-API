using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WitcherTRPGWebApplication.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public readonly WitcherContext _context;
        public DefaultController(WitcherContext context)
        {
            _context = context;
        }

        // GET: api/Default
        [HttpGet]
        public Weapon Get()
        {
            var weapon = _context.Weapons.First();
            return weapon;
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
