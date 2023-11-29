using AutoMapper;
using tennis_tourneys_api.DTOs;
using tennis_tourneys_api.Entities;

namespace tennis_tourneys_api.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Player, PlayerDTO>().ReverseMap();
            CreateMap<PlayerCreationDTO, Player>();
        }
    }
}
