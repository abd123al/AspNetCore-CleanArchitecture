using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data.Repository;

public abstract class Repository<TModel> : IRepository<TModel>
    where TModel : class
{
#pragma warning disable SA1401
    protected readonly AppDbContext _dbContext;
#pragma warning restore SA1401

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TModel?> GetAsync(int id)
    {
        return await _dbContext.Set<TModel>().FindAsync(id);
    }

    public async Task<IEnumerable<TModel>> GetAllAsync()
    {
        return await _dbContext.Set<TModel>().ToListAsync();
    }

    public void Add(TModel entity)
    {
        _dbContext.Set<TModel>().Add(entity);
    }

    public void Remove(TModel entity)
    {
        _dbContext.Set<TModel>().Remove(entity);
    }

    public async Task<int> SaveChangeAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
