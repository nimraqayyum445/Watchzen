using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Watchzen.Model;

namespace Watchzen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchController : ControllerBase
    {
        [HttpPut]
        public async Task<IActionResult> Put(Watches watches)
        {
            using (var db = new WatchesDbContext())
            {
                db.Watches.Add(watches);
                await db.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using (var db = new WatchesDbContext())
            {
                var watches = await db.Watches.ToListAsync();
                return Ok(watches);
            }
        }

    }
}
