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
            builder.Property(w => w.Email).HasMaxLength(50);
            builder.Property(w => w.Password).HasMaxLength(20);

            builder.HasData
                (
                    new Writer() {Id = 1,FirstName="Ali",LastName="Yıldız",Email="aliyildiz@gmail.com",Password="1",IsActive = true,CreatedDate = DateTime.UtcNow },
                    new Writer() {Id = 2,FirstName="Mehmet",LastName="Çınar",Email="mehmet@gmail.com",Password="11",IsActive = true,CreatedDate = DateTime.UtcNow },
                    new Writer() {Id = 3,FirstName="Emel",LastName="Öztürk",Email="emel@gmail.com",Password="123",IsActive = true,CreatedDate = DateTime.UtcNow },
                    new Writer() {Id = 4,FirstName="Gizem",LastName="Yıldız",Email="gizem@hotmail.com",Password="10",IsActive = true,CreatedDate = DateTime.UtcNow },
                    new Writer() {Id = 5,FirstName="Aslı",LastName="Kaya",Email="asli@gmail.com",Password="00011",IsActive = true,CreatedDate = DateTime.UtcNow }
                );

            builder.ToTable("Writers");
        }
    }


}
