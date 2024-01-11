using Scrutor.Api.Demo.Models;
using Scrutor.Api.Demo.Repositories;

namespace Scrutor.Api.Demo
{
    public static class RegisterRepository
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            var assembly = typeof(IRepository<>).Assembly;

            services.Scan(x => x.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(IRepository<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return services;
        }   
    }
}