using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Persistence.EntitiesMapping
{
    public class ContentMap : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.Property(c => c.Value).HasMaxLength(1000);

            builder.HasData
                (
                    new Content() { Id = 1, HeadingId = 1, WriterId = 3, Value = "Walter White'ın efsane yaşam öyküsü", CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Content() { Id = 2, HeadingId = 1, WriterId = 4, Value = "Küçük Walter seni çok özledik keşke bu dizi devam etse", CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Content() { Id = 3, HeadingId = 2, WriterId = 1, Value = "Bu film 2019 yılında Oscar ödülüne aday oldu ve Oscar ödülünü almayı başardı", CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Content() { Id = 4, HeadingId = 2, WriterId = 3, Value = "WÇok beğendiğim efsane bir film olmuş", CreatedDate = DateTime.UtcNow, IsActive = true },
                    new Content() { Id = 5, HeadingId = 2, WriterId = 5, Value = "Hayatımda izlediğim en iyi 10 filmden biri oldu.", CreatedDate = DateTime.UtcNow, IsActive = true }
                );

            builder.ToTable("Contents");
        }
    }


}
