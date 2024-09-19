using Domain.Entities.Aggrigators.Users.Master;

namespace EducationalApi.Domain.Entities.Aggrigators.Users.Masters
{
    public interface IMasterRepository
    {
        void Add(Master master);

        Task<Master?> FindMastersAsync(long id);

        Task<IReadOnlyList<Master>> GetAll(CancellationToken cancellationToken);
    }
}