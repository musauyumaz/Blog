using Blog.Application.Abstractions.Storage;
using Blog.Infrastructure.Services.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {

        }
        public static void AddStorage<T>(this IServiceCollection services) where T : Storage, IStorage
        {
            services.AddScoped<IStorage, T>();
        }
    }
}
