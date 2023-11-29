using System.ComponentModel.DataAnnotations;

namespace tennis_tourneys_api.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Location  { get; set; }
        public string? Mode { get; set; }
        public string? NumberOfRounds { get; set; }
        public int NumberOfPlayers { get; set; }
    }
}
