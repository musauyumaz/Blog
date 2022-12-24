using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Persistence.EntitiesMapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(200);


            builder.HasData(
                new Category() { Id = 1, Name = "Eğitim", Description = "Burası Eğitim Kategorisidir.", IsActive = true, CreatedDate = DateTime.UtcNow },
                new Category() { Id = 2, Name = "Tiyatro", Description = "Burası Tiyatro Kategorisidir.", IsActive = true, CreatedDate = DateTime.UtcNow },
                new Category() { Id = 3, Name = "Kitap", Description = "Burası Kitap Kategorisidir.", IsActive = true, CreatedDate = DateTime.UtcNow },
                new Category() { Id = 4, Name = "Spor", Description = "Burası Spor Kategorisidir.", IsActive = true, CreatedDate = DateTime.UtcNow },
                new Category() { Id = 5, Name = "Film", Description = "Burası Film Kategorisidir.", IsActive = true, CreatedDate = DateTime.UtcNow },
                new Category() { Id = 6, Name = "Dizi", Description = "Burası Dizi Kategorisidir.", IsActive = true, CreatedDate = DateTime.UtcNow }
                );

            builder.ToTable("Categories");
        }
    }


}
