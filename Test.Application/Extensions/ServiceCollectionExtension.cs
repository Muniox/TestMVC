using Microsoft.Extensions.DependencyInjection;
using Test.Application.TodoList;

namespace Test.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ITodoTaskService, TodoTaskService>();
        }
    }
}
