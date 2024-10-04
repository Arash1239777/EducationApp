using Domain.Entities.Aggrigators.Users.Master;
using EducationalApi.Domain.Entities.Aggrigators.Users.Masters;
using Microsoft.EntityFrameworkCore;

namespace EducationalApi.Infra.Repositories.Users.Masters
{
    public class MasterRepository : IMasterRepository
    {
        private readonly AppDbContext _context;

        public MasterRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Master master)
            => _context.Masters.Add(master);


        public async Task<Master?> FindMastersAsync(long id)
            => await _context.Masters.FindAsync(id);


        public async Task<IReadOnlyList<Master>> GetAll(CancellationToken cancellationToken)
            => await _context.Masters
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync(cancellationToken);
    }
}
