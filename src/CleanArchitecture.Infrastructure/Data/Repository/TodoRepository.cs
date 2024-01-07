using CleanArchitecture.Core.TodoAggregate;

namespace CleanArchitecture.Infrastructure.Data.Repository;

public class TodoRepository : Repository<Todo>, ITodoRepository
{
    public AppDbContext AppDbContext
    {
        get => _dbContext;
    }

    public TodoRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}
