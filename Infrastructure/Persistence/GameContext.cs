using Actors.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class GameDbContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public GameDbContext(DbContextOptions<GameDbContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
