using Actors.Models;
using Domain.Entities.Character;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ExampleContext : DbContext
    {
        public DbSet<ExampleEntity> Example { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QHUPRK4\SQLEXPRESS;Initial Catalog=Example;Integrated Security=True;", b => b.MigrationsAssembly("Infrastructure"));
        }
    }
}
