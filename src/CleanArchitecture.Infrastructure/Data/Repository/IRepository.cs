namespace CleanArchitecture.Infrastructure.Data.Repository;

public interface IRepository<TModel>
    where TModel : class
{
    Task<TModel?> GetAsync(int id);

    Task<IEnumerable<TModel>> GetAllAsync();

    void Add(TModel entity);

    void Remove(TModel entity);

    Task<int> SaveChangeAsync();

    Task<int> SaveChangeAsync(CancellationToken cancellationToken);
}
