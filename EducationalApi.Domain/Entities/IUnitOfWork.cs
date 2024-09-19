using EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;

namespace EducationalApi.Domain.Entities;
public interface IUnitOfWork : IDisposable
{
    public IClerckRepository ClerckRepository { get; set; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
    Task BeginTransactionAsync(CancellationToken cancellationToken);
    Task CommitAsync(CancellationToken cancellationToken);
    Task RollbackAsync(CancellationToken cancellationToken);
}
