using System.ComponentModel.DataAnnotations;

namespace tennis_tourneys_api.Entities
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Points { get; set; }

        public string Photo {  get; set; }
        public string? Category { get; set; }
    }
}
