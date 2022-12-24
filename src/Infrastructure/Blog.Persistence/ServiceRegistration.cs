using Blog.Application.Abstractions.Services;
using Blog.Application.Repositories.AboutImageFiles;
using Blog.Application.Repositories.Abouts;
using Blog.Application.Repositories.Categories;
using Blog.Application.Repositories.Contacts;
using Blog.Application.Repositories.Contents;
using Blog.Application.Repositories.Files;
using Blog.Application.Repositories.Headings;
using Blog.Application.Repositories.WriterImageFiles;
using Blog.Application.Repositories.Writers;
using Blog.Persistence.Configurations;
using Blog.Persistence.Contexts;
using Blog.Persistence.Repositories.AboutImageFiles;
using Blog.Persistence.Repositories.Abouts;
using Blog.Persistence.Repositories.Categories;
using Blog.Persistence.Repositories.Contacts;
using Blog.Persistence.Repositories.Contents;
using Blog.Persistence.Repositories.Files;
using Blog.Persistence.Repositories.Headings;
using Blog.Persistence.Repositories.WriterImageFiles;
using Blog.Persistence.Repositories.Writers;
using Blog.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options=> options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IAboutImageFileReadRepository, AboutImageFileReadRepository>();
            services.AddScoped<IAboutImageFileWriteRepository, AboutImageFileWriteRepository>();
            services.AddScoped<IAboutReadRepository, AboutReadRepository>();
            services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<IContactReadRepository, ContactReadRepository>();
            services.AddScoped<IContactWriteRepository, ContactWriteRepository>();
            services.AddScoped<IContentReadRepository, ContentReadRepository>();
            services.AddScoped<IContentWriteRepository, ContentWriteRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IHeadingReadRepository, HeadingReadRepository>();
            services.AddScoped<IHeadingWriteRepository, HeadingWriteRepository>();
            services.AddScoped<IWriterImageFileReadRepository, WriterImageFileReadRepository>();
            services.AddScoped<IWriterImageFileWriteRepository, WriterImageFileWriteRepository>();
            services.AddScoped<IWriterReadRepository, WriterReadRepository>();
            services.AddScoped<IWriterWriteRepository, WriterWriteRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
