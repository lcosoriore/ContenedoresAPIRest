using ADO.EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ADO.EntityFrameworkCore
{
    public class ContainerContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ContainerContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(@"User Id=root;Host=localhost;Database=Test;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StatsModel>()
              .HasKey(p => new { p.containers_dispatched, p.containers_not_dispatched,p.budget_used });
        }
        public DbSet<StatsModel> Stats { get; set; }

    }
}