// <auto-generated />
using System;
using Blog.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Persistence.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    partial class BlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AboutAboutImageFile", b =>
                {
                    b.Property<int>("AboutImageFilesId")
                        .HasColumnType("int");

                    b.Property<int>("AboutsId")
                        .HasColumnType("int");

                    b.HasKey("AboutImageFilesId", "AboutsId");

                    b.HasIndex("AboutsId");

                    b.ToTable("AboutAboutImageFile");
                });

            modelBuilder.Entity("Blog.Domain.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Abouts", (string)null);
                });

            modelBuilder.Entity("Blog.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4273),
                            Description = "Burası Eğitim Kategorisidir.",
                            IsActive = true,
                            Name = "Eğitim",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4276),
                            Description = "Burası Tiyatro Kategorisidir.",
                            IsActive = true,
                            Name = "Tiyatro",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4278),
                            Description = "Burası Kitap Kategorisidir.",
                            IsActive = true,
                            Name = "Kitap",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4280),
                            Description = "Burası Spor Kategorisidir.",
                            IsActive = true,
                            Name = "Spor",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4281),
                            Description = "Burası Film Kategorisidir.",
                            IsActive = true,
                            Name = "Film",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4283),
                            Description = "Burası Dizi Kategorisidir.",
                            IsActive = true,
                            Name = "Dizi",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Blog.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contacts", (string)null);
                });

            modelBuilder.Entity("Blog.Domain.Entities.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HeadingId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HeadingId");

                    b.HasIndex("WriterId");

                    b.ToTable("Contents", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1061),
                            HeadingId = 1,
                            IsActive = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = "Walter White'ın efsane yaşam öyküsü",
                            WriterId = 3
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1065),
                            HeadingId = 1,
                            IsActive = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = "Küçük Walter seni çok özledik keşke bu dizi devam etse",
                            WriterId = 4
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1068),
                            HeadingId = 2,
                            IsActive = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = "Bu film 2019 yılında Oscar ödülüne aday oldu ve Oscar ödülünü almayı başardı",
                            WriterId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1069),
                            HeadingId = 2,
                            IsActive = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = "WÇok beğendiğim efsane bir film olmuş",
                            WriterId = 3
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1071),
                            HeadingId = 2,
                            IsActive = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = "Hayatımda izlediğim en iyi 10 filmden biri oldu.",
                            WriterId = 5
                        });
                });

            modelBuilder.Entity("Blog.Domain.Entities.Files.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");

                    b.HasDiscriminator<string>("Discriminator").HasValue("File");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Blog.Domain.Entities.Heading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WriterId");

                    b.ToTable("Headings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 6,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4046),
                            IsActive = true,
                            Name = "Breaking Bad",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WriterId = 3
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4050),
                            IsActive = true,
                            Name = "Green Book",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WriterId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4051),
                            IsActive = true,
                            Name = "İtiraflarım",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WriterId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 6,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4053),
                            IsActive = true,
                            Name = "La Casa De Papel",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WriterId = 4
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4054),
                            IsActive = true,
                            Name = "Venedik Taciri",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WriterId = 5
                        });
                });

            modelBuilder.Entity("Blog.Domain.Entities.Writer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Writers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Yazılım Mühendisi, Frontend Developer",
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6562),
                            Email = "aliyildiz@gmail.com",
                            FirstName = "Ali",
                            IsActive = true,
                            LastName = "Yıldız",
                            Password = "1",
                            Title = "",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            About = "Senior Software Developer, Bolca Kitap Okur",
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6580),
                            Email = "mehmet@gmail.com",
                            FirstName = "Mehmet",
                            IsActive = true,
                            LastName = "Çınar",
                            Password = "11",
                            Title = "",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            About = "Tiyatro, Filtre Kahve",
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6582),
                            Email = "emel@gmail.com",
                            FirstName = "Emel",
                            IsActive = true,
                            LastName = "Öztürk",
                            Password = "123",
                            Title = "",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            About = "Spor, Bisiklet, Dergiler ve Karikatürler",
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6588),
                            Email = "gizem@hotmail.com",
                            FirstName = "Gizem",
                            IsActive = true,
                            LastName = "Yıldız",
                            Password = "10",
                            Title = "",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            About = "Kahve vazgeçilmezim yanında bolca kod ile",
                            CreatedDate = new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6601),
                            Email = "asli@gmail.com",
                            FirstName = "Aslı",
                            IsActive = true,
                            LastName = "Kaya",
                            Password = "00011",
                            Title = "",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WriterWriterImageFile", b =>
                {
                    b.Property<int>("WriterImageFilesId")
                        .HasColumnType("int");

                    b.Property<int>("WritersId")
                        .HasColumnType("int");

                    b.HasKey("WriterImageFilesId", "WritersId");

                    b.HasIndex("WritersId");

                    b.ToTable("WriterWriterImageFile");
                });

            modelBuilder.Entity("Blog.Domain.Entities.Files.AboutImageFile", b =>
                {
                    b.HasBaseType("Blog.Domain.Entities.Files.File");

                    b.HasDiscriminator().HasValue("AboutImageFile");
                });

            modelBuilder.Entity("Blog.Domain.Entities.Files.WriterImageFile", b =>
                {
                    b.HasBaseType("Blog.Domain.Entities.Files.File");

                    b.HasDiscriminator().HasValue("WriterImageFile");
                });

            modelBuilder.Entity("AboutAboutImageFile", b =>
                {
                    b.HasOne("Blog.Domain.Entities.Files.AboutImageFile", null)
                        .WithMany()
                        .HasForeignKey("AboutImageFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Domain.Entities.About", null)
                        .WithMany()
                        .HasForeignKey("AboutsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Domain.Entities.Content", b =>
                {
                    b.HasOne("Blog.Domain.Entities.Heading", "Heading")
                        .WithMany("Contents")
                        .HasForeignKey("HeadingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Domain.Entities.Writer", "Writer")
                        .WithMany("Contents")
                        .HasForeignKey("WriterId");

                    b.Navigation("Heading");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Blog.Domain.Entities.Heading", b =>
                {
                    b.HasOne("Blog.Domain.Entities.Category", "Category")
                        .WithMany("Headings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Domain.Entities.Writer", "Writer")
                        .WithMany("Headings")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("WriterWriterImageFile", b =>
                {
                    b.HasOne("Blog.Domain.Entities.Files.WriterImageFile", null)
                        .WithMany()
                        .HasForeignKey("WriterImageFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Domain.Entities.Writer", null)
                        .WithMany()
                        .HasForeignKey("WritersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Domain.Entities.Category", b =>
                {
                    b.Navigation("Headings");
                });

            modelBuilder.Entity("Blog.Domain.Entities.Heading", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("Blog.Domain.Entities.Writer", b =>
                {
                    b.Navigation("Contents");

                    b.Navigation("Headings");
                });
#pragma warning restore 612, 618
        }
    }
}
