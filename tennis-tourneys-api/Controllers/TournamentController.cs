using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tennis_tourneys_api.Entities;

namespace tennis_tourneys_api.Controllers
{
    [ApiController]
    [Route("api/tournament")]
    public class TournamentController: ControllerBase
    {

        private readonly ApplicationDbContext context;
        public TournamentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet] 
        public async Task<ActionResult<List<Tournament>>> Get()
        {
            return await context.Tournament.ToListAsync();
        }
    }
}
