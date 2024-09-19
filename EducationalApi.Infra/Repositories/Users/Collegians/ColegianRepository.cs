using Domain.Entities.Aggrigators.Users.Collegian;
using EducationalApi.Domain.Entities.Aggrigators.Users.Collegians;

namespace EducationalApi.Infra.Repositories.Users.Collegians;
internal class ColegianRepository : ICollegianRepository
{
    public void Add(Collegian collegian)
    {
        throw new NotImplementedException();
    }

    public Task<Collegian?> FindCollegiansAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Collegian?> FindCollegiansByRoleNumberAsync(string RoleNumber, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Collegian>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
