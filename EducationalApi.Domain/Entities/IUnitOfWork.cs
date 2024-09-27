using EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;
using EducationalApi.Domain.Entities.Aggrigators.Users.Collegians;
using EducationalApi.Domain.Entities.Aggrigators.Users.Masters;

namespace EducationalApi.Domain.Entities;
public interface IUnitOfWork : IDisposable
{
    public IClerckRepository ClerckRepository { get; set; }
    public IMasterRepository MasterRepository { get; set; }
    public ICollegianRepository CollegianRepository { get; set; }
    Task SaveChangesAsync(CancellationToken cancellationToken);
    Task BeginTransactionAsync(CancellationToken cancellationToken);
    Task CommitAsync(CancellationToken cancellationToken);
    Task RollbackAsync(CancellationToken cancellationToken);
}
