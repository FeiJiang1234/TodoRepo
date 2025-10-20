using Todo.Domain;
using Todo.Domain.Abstractions;

namespace Todo.Infrastructure.Repositories
{
    public class TodoRepository : Repository<TodoItem>, ITodoRepository
    {
        public TodoRepository(TodoDbContext dbContext) : base(dbContext)
        {

        }
    }
}
