using Todo.Domain.Abstractions;

namespace Todo.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public TodoDbContext DbContext { get; }

        public UnitOfWork(TodoDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           return await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
