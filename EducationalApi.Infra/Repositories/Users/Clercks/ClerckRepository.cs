using Domain.Entities.Aggrigators.Users.Clerks;
using EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;
using Microsoft.EntityFrameworkCore;

namespace EducationalApi.Infra.Repositories.Users.Clercks;
internal class ClerckRepository(AppDbContext context) : IClerckRepository
{
    public void Add(Clerks clerk)
    {
        context.Clercks.Add(clerk);
    }

    public async Task<Clerks?> FindClerksAsync(long id)
        => await context.Clercks.FindAsync(id);

    public async Task<Clerks?> FindClerksByUserNameAsync(long userCode, CancellationToken cancellationToken)
        => await context.Clercks
        .AsTracking()
        .FirstOrDefaultAsync(clerk => clerk.UserCode.Equals(userCode), cancellationToken);

    public async Task<IReadOnlyList<Clerks>> GetAll(CancellationToken cancellationToken)
        => await context.Clercks
        .AsNoTrackingWithIdentityResolution()
        .ToListAsync(cancellationToken);
}
