using Blog.Domain.Entities;
using Blog.Domain.Entities.Common;
using Blog.Domain.Entities.Files;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Blog.Persistence.Contexts
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Domain.Entities.Files.File> Files { get; set; }
        public DbSet<AboutImageFile> AboutImageFiles { get; set; }
        public DbSet<WriterImageFile> WriterImageFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                if (data.State == EntityState.Added)
                {
                    data.Entity.CreatedDate = DateTime.UtcNow;
                    data.Entity.IsActive = true;
                }
                else if (data.State == EntityState.Modified)
                    data.Entity.UpdatedDate = DateTime.UtcNow;
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
