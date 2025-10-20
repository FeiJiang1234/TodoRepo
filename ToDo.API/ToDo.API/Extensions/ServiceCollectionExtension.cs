using Todo.Application;
using Todo.Domain.Abstractions;
using Todo.Infrastructure;
using Todo.Infrastructure.Repositories;

namespace ToDo.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddTodoServices(this IServiceCollection services)
        {
            services.AddScoped<TodoService>();
            services.AddScoped<ITodoRepository, TodoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
