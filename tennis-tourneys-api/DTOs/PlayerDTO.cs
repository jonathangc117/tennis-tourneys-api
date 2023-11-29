namespace tennis_tourneys_api.DTOs
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Points { get; set; }
        public string? Category { get; set; }
    }
}
