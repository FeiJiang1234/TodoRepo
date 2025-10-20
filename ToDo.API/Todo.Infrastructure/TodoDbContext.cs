using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Todo.Domain;

namespace Todo.Infrastructure
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems => Set<TodoItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
