using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;
using Microsoft.EntityFrameworkCore.Storage;

namespace EducationalApi.Infra;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;
    private IDbContextTransaction _transaction;
    internal UnitOfWork(
        AppDbContext appDbContext,
        IClerckRepository clerckRepository,
        IDbContextTransaction transaction)
    {
        ClerckRepository = clerckRepository;
        _appDbContext = appDbContext;
        _transaction = transaction; 
    }
    public IClerckRepository ClerckRepository { get; set; }

    public async Task BeginTransactionAsync(CancellationToken cancellationToken) 
        => _transaction = await _appDbContext.Database.BeginTransactionAsync(cancellationToken);

    public async Task CommitAsync(CancellationToken cancellationToken)
    {
        try
        {
            await SaveChangesAsync(cancellationToken);
            await _transaction.CommitAsync(cancellationToken);
        }
        finally
        {
            await _transaction.DisposeAsync();
        }
    }

    public void Dispose()
    {
        _appDbContext.Dispose();
        GC.SuppressFinalize(this);
    }

    public async Task RollbackAsync(CancellationToken cancellationToken)
    {
        await _transaction.RollbackAsync(cancellationToken);
        await _transaction.DisposeAsync();
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken) 
        =>  await _appDbContext.SaveChangesAsync(cancellationToken);
}
