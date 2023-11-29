using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tennis_tourneys_api.DTOs;
using tennis_tourneys_api.Entities;

namespace tennis_tourneys_api.Controllers
{
    [ApiController]
    [Route("api/player")]
    public class PlayerController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PlayerController(
            ApplicationDbContext context,
            IMapper mapper
            )
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlayerDTO>>> Get()
        {
            var entities = await context.Player.ToListAsync();
            var dtos = mapper.Map<List<PlayerDTO>>(entities);
            return dtos;
        }

        [HttpGet("{id:int}", Name = "getPlayer")]
        public async Task<ActionResult<PlayerDTO>> Get(int id)
        {
            var entity = await context.Player.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                return NotFound();
            }

            var dto = mapper.Map<PlayerDTO>(entity);

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PlayerCreationDTO creationDTO)
        {
            var entity = mapper.Map<Player>(creationDTO);
            context.Add(entity);

            await context.SaveChangesAsync();

            var playerDTO = mapper.Map<PlayerDTO>(entity);

            return new CreatedAtRouteResult("getPlayer", new {id = playerDTO.Id}, playerDTO );
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] PlayerCreationDTO creationDTO)
        {  
            var entity = mapper.Map<Player>(creationDTO);

            entity.Id = id;
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = context.Player.AnyAsync(x => x.Id == id);

            if (exists == null)
            {
                return NotFound();
            }

            context.Remove(new Player { Id = id});

            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
