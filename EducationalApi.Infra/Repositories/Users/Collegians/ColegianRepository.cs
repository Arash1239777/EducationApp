using Domain.Entities.Aggrigators.Users.Collegian;
using EducationalApi.Domain.Entities.Aggrigators.Users.Collegians;
using Microsoft.EntityFrameworkCore;

namespace EducationalApi.Infra.Repositories.Users.Collegians;
internal class ColegianRepository : ICollegianRepository
{
    private readonly AppDbContext _context;

    public ColegianRepository(AppDbContext context)
    {
        _context = context;
    }


    public void Add(Collegian collegian)
        => _context.Collegians.Add(collegian);

    public async Task<Collegian?> FindCollegiansAsync(long id)
        => await _context.Collegians.FindAsync(id);

    public async Task<Collegian?> FindCollegiansByRoleNumberAsync(string RoleNumber, CancellationToken cancellationToken)
        => await _context.Collegians
            .AsTracking()
            .FirstOrDefaultAsync(collegian => collegian.RoleNumber.Equals(RoleNumber), cancellationToken);

    public async Task<IReadOnlyList<Collegian>> GetAll(CancellationToken cancellationToken)
        => await _context.Collegians
            .AsNoTrackingWithIdentityResolution()
            .ToListAsync(cancellationToken);
}
