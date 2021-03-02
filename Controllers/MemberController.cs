using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cardinal_api.Data;
using Cardinal_api.Models;

namespace Cardinal_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController
    {
        private readonly Context _context;

        public MemberController(Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMemberById(string id)
        {
            Member memb = await _context.Members.FindAsync(id);

            if (memb == null)
                return new NotFoundObjectResult(memb);
            return memb;
        }
    }
}