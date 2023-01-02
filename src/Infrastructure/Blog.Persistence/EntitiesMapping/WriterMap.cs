using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Persistence.EntitiesMapping
{
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.Property(w => w.FirstName).HasMaxLength(50);
            builder.Property(w => w.LastName).HasMaxLength(50);
            builder.Property(w => w.About).HasMaxLength(100);
            builder.Property(w => w.Email).HasMaxLength(200);
            builder.Property(w => w.Password).HasMaxLength(200);

            builder.HasData
                (
                    new Writer() { Id = 1, FirstName = "Ali", LastName = "Yıldız", About = "Yazılım Mühendisi, Frontend Developer", Email = "aliyildiz@gmail.com", Password = "1", IsActive = true, CreatedDate = DateTime.UtcNow },
                    new Writer() { Id = 2, FirstName = "Mehmet", LastName = "Çınar", About = "Senior Software Developer, Bolca Kitap Okur", Email = "mehmet@gmail.com", Password = "11", IsActive = true, CreatedDate = DateTime.UtcNow },
                    new Writer() { Id = 3, FirstName = "Emel", LastName = "Öztürk", About = "Tiyatro, Filtre Kahve", Email = "emel@gmail.com", Password = "123", IsActive = true, CreatedDate = DateTime.UtcNow },
                    new Writer() { Id = 4, FirstName = "Gizem", LastName = "Yıldız", About = "Spor, Bisiklet, Dergiler ve Karikatürler", Email = "gizem@hotmail.com", Password = "10", IsActive = true, CreatedDate = DateTime.UtcNow },
                    new Writer() { Id = 5, FirstName = "Aslı", LastName = "Kaya", About = "Kahve vazgeçilmezim yanında bolca kod ile", Email = "asli@gmail.com", Password = "00011", IsActive = true, CreatedDate = DateTime.UtcNow }
                );

            builder.ToTable("Writers");
        }
    }


}
