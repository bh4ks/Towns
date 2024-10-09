using Microsoft.EntityFrameworkCore;
using Towns.webapi.Models;

namespace Towns.webapi.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public ApplicationDbContext() { }

        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Town>().ToTable("Towns");

            modelBuilder.Entity<Town>().HasData(new Town { TownID = Guid.NewGuid(), TownName = "Plumtree" });
            modelBuilder.Entity<Town>().HasData(new Town { TownID = Guid.NewGuid(), TownName = "Bulawayo" });
            modelBuilder.Entity<Town>().HasData(new Town { TownID = Guid.NewGuid(), TownName = "Gaborone" });
            modelBuilder.Entity<Town>().HasData(new Town { TownID = Guid.NewGuid(), TownName = "Mochudi" });
        }
    }
}
