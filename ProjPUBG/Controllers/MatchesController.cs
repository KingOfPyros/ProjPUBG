using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjPUBG.Controllers
{
    [ApiController]
    [Route("api/matches")]
    public class MatchesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MatchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMatches()
        {
            var matches = _context.Matches.ToList();
            return Ok(matches);
        }

        [HttpPost]
        public IActionResult CreateMatch([FromBody] Match match)
        {
            _context.Matches.Add(match);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMatches), null);
        }
    }
}
