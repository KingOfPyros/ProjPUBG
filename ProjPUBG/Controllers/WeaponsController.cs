using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjPUBG.Controllers
{
    [ApiController]
    [Route("api/weapons")]
    public class WeaponsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WeaponsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetWeapons()
        {
            var weapons = _context.Weapons.ToList();
            return Ok(weapons);
        }

        [HttpPost]
        public IActionResult CreateWeapon([FromBody] Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetWeapons), null);
        }
    }
}
