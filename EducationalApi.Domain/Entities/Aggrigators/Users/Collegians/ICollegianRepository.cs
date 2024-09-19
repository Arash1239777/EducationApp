using Domain.Entities.Aggrigators.Users.Collegian;

namespace EducationalApi.Domain.Entities.Aggrigators.Users.Collegians
{
    public interface ICollegianRepository
    {
        void Add(Collegian collegian);

        Task<Collegian?> FindCollegiansAsync(long id);

        Task<Collegian?> FindCollegiansByRoleNumberAsync(string RoleNumber, CancellationToken cancellationToken);

        Task<IReadOnlyList<Collegian>> GetAll(CancellationToken cancellationToken);
    }
}