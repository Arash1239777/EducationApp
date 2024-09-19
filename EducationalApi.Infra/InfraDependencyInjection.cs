using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;
using EducationalApi.Infra.Repositories.Users.Clercks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EducationalApi.Infra;
public static class InfraDependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DB_Connection") ??
                               throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IClerckRepository, ClerckRepository>();

        return services;
    }
}
