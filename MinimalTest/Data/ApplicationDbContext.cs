using Microsoft.EntityFrameworkCore;
using MinimalTest.Models;

namespace MinimalTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=192.168.1.6;Database=DBName;User ID=dvduser;Password=dvdpassword;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
