using LocationVoiture.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationVoiture.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }


        public AppDbContext() { }

        public DbSet<Assurance> Assurances { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Marque> Marques { get; set; }

        public DbSet<Voiture> Voitures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
