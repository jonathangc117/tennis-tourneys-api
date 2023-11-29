using System.ComponentModel.DataAnnotations;

namespace tennis_tourneys_api.DTOs
{
    public class PlayerCreationDTO
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Points { get; set; }
    }
}
