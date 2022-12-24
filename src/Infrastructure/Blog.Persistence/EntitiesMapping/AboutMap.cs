using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Persistence.EntitiesMapping
{
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.Property(a => a.Detail).HasMaxLength(1000);

            builder.ToTable("Abouts");
        }
    }
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(200);

            builder.ToTable("Categories");
        }
    }
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(c => c.FullName).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Subject).HasMaxLength(50);
            builder.Property(c => c.Message).HasMaxLength(1000);

            builder.ToTable("Contacts");
        }
    }
    public class ContentMap : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.Property(c => c.Value).HasMaxLength(1000);

            builder.ToTable("Contents");
        }
    }
    public class HeadingMap : IEntityTypeConfiguration<Heading>
    {
        public void Configure(EntityTypeBuilder<Heading> builder)
        {
            builder.Property(h => h.Name).HasMaxLength(50);

            builder.ToTable("Headings");
        }
    }
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.Property(w => w.FirstName).HasMaxLength(50);
            builder.Property(w => w.LastName).HasMaxLength(50);
            builder.Property(w => w.Email).HasMaxLength(50);
            builder.Property(w => w.Password).HasMaxLength(20);

            builder.ToTable("Writers");
        }
    }


}
