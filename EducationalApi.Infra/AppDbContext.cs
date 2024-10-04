using Domain.Entities.Aggrigators.Users.Clerk;
using Domain.Entities.Aggrigators.Users.Collegian;
using Domain.Entities.Aggrigators.Users.Master;
using Microsoft.EntityFrameworkCore;

namespace EducationalApi.Infra
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Clerks> Clercks { get; set; }
        public DbSet<Collegian> Collegians { get; set; }
        public DbSet<Master> Masters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
