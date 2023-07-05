using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjPUBG.Controllers
{
    [ApiController]
    [Route("api/contentadmins")]
    public class ContentAdminsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContentAdminsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetContentAdmins()
        {
            var contentAdmins = _context.ContentAdmins.ToList();
            return Ok(contentAdmins);
        }

        [HttpPost]
        public IActionResult CreateContentAdmin([FromBody] ContentAdmin contentAdmin)
        {
            _context.ContentAdmins.Add(contentAdmin);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetContentAdmins), null);
        }
    }
}
