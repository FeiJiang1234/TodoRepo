using Todo.Application;

namespace ToDo.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddTodoServices(this IServiceCollection services)
        {
            services.AddScoped<TodoService>();
            return services;
        }
    }
}
