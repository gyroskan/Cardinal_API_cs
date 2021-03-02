using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Cardinal_api.Models;
using Cardinal_api.Data;

namespace Cardinal_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuildController
    {
        private readonly Context _context;

        public GuildController(Context context)
        {
            _context = context;
        }

        [HttpGet("{guildID}")]
        public async Task<ActionResult<Guild>> GetGuildById(int guildID)
        {
            Guild guild = await _context.Guilds.FindAsync(guildID);
            if (guild == null)
                return new NotFoundObjectResult(guild);
            guild.Owner = await _context.Members.FindAsync(guild.OwnerID, guildID);
            var t = _context.Members.Where(m => m.GuildID__ == guildID);
            Console.WriteLine("gotit");
            guild.Members = await t.ToListAsync();

            return guild;
        }

        [HttpGet("{guildID}/{membID}")]
        public async Task<ActionResult<Member>> GetMemberById(string membID)
        {
            Member memb = await _context.Members.FindAsync(membID);

            if (memb == null)
                return new NotFoundObjectResult(memb);
            return memb;
        }
    }
}