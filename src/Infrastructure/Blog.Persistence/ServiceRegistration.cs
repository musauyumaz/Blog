using Blog.Persistence.Configurations;
using Blog.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options=> options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
