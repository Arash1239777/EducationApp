using Domain.Entities.Aggrigators.Users.Clerk;

namespace EducationalApi.Domain.Entities.Aggrigators.Users.Clerk;
public interface IClerckRepository
{
    void Add(Clerks clerk);

    Task<Clerks?> FindClerksAsync(long id);

    Task<Clerks?> FindClerksByUserNameAsync(long userCode, CancellationToken cancellationToken);

    Task<IReadOnlyList<Clerks>> GetAll(CancellationToken cancellationToken);
}
