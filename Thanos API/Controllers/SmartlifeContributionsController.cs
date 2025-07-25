using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thanos_API.Data;
using Thanos_API.Models;

namespace Thanos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmartlifeContributionsController : ControllerBase
    {
        private readonly SmartlifeDbContext _context;

        public SmartlifeContributionsController(SmartlifeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contribution>>> GetContributions()
        {
            var contributions = await _context.Contributions.ToListAsync();
            return Ok(contributions);
        }
    }
}
