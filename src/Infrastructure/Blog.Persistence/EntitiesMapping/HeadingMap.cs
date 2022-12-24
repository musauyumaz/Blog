using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Persistence.EntitiesMapping
{
    public class HeadingMap : IEntityTypeConfiguration<Heading>
    {
        public void Configure(EntityTypeBuilder<Heading> builder)
        {
            builder.Property(h => h.Name).HasMaxLength(50);

            builder.HasData
                (
                    new Heading() { Id = 1, Name = "Breaking Bad", CategoryId = 6, WriterId = 3, CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Heading() { Id = 2, Name = "Green Book", CategoryId = 5, WriterId = 1, CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Heading() { Id = 3, Name = "İtiraflarım", CategoryId = 3, WriterId = 1, CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Heading() { Id = 4, Name = "La Casa De Papel", CategoryId = 6, WriterId = 4, CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Heading() { Id = 5, Name = "Venedik Taciri", CategoryId = 2, WriterId = 5, CreatedDate = DateTime.UtcNow, IsActive = true }
                );

            builder.ToTable("Headings");
        }
    }


}
