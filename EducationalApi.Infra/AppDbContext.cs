using Domain.Entities.Aggrigators.Users.Clerks;
using Microsoft.EntityFrameworkCore;

namespace EducationalApi.Infra
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Clerks> Clercks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
