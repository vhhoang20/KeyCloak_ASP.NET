using KeyCloak.Data;
using KeyCloak.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KeyCloak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TestController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("task")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Sprint>>> GetProducts()
        {
            var result = await _context.Sprints.ToListAsync();
            return result;
        }
    }
}
