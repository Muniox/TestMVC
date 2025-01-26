using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test.Domain.RepositoryInterfaces;
using Test.Infrastructure.Persistence;
using Test.Infrastructure.Repositories;

namespace Test.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TestDbContext>(options => options.UseMySql(
                configuration.GetConnectionString("NetTest"),
                new MariaDbServerVersion(new Version(10, 5, 0))
                ));


            services.AddScoped<ITodoTaskRepository, TodoTaskRepository>();
        }
    }
}
