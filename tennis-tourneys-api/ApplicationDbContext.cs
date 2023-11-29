using Microsoft.EntityFrameworkCore;
using tennis_tourneys_api.Entities;

namespace tennis_tourneys_api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}
