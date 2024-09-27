using Domain.Entities.Aggrigators.Users.Clerk;
using EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;
using Microsoft.EntityFrameworkCore;

namespace EducationalApi.Infra.Repositories.Users.Clercks;
internal class ClerckRepository : IClerckRepository
{
    private readonly AppDbContext _context;
    public ClerckRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(Clerks clerk)
    {
        _context.Clercks.Add(clerk);
    }

    public async Task<Clerks?> FindClerksAsync(long id)
        => await _context.Clercks.FindAsync(id);

    public async Task<Clerks?> FindClerksByUserNameAsync(long userCode, CancellationToken cancellationToken)
        => await _context.Clercks
        .AsTracking()
        .FirstOrDefaultAsync(clerk => clerk.UserCode.Equals(userCode), cancellationToken);

    public async Task<IReadOnlyList<Clerks>> GetAll(CancellationToken cancellationToken)
        => await _context.Clercks
        .AsNoTrackingWithIdentityResolution()
        .ToListAsync(cancellationToken);
}
