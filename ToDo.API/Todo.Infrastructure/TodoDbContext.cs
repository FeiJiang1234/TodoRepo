using Microsoft.EntityFrameworkCore;
using Todo.Domain;

namespace Todo.Infrastructure
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems => Set<TodoItem>();

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
