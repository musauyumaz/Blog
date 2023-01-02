using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    About = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutAboutImageFile",
                columns: table => new
                {
                    AboutImageFilesId = table.Column<int>(type: "int", nullable: false),
                    AboutsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutAboutImageFile", x => new { x.AboutImageFilesId, x.AboutsId });
                    table.ForeignKey(
                        name: "FK_AboutAboutImageFile_Abouts_AboutsId",
                        column: x => x.AboutsId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutAboutImageFile_Files_AboutImageFilesId",
                        column: x => x.AboutImageFilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Headings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Headings_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriterWriterImageFile",
                columns: table => new
                {
                    WriterImageFilesId = table.Column<int>(type: "int", nullable: false),
                    WritersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterWriterImageFile", x => new { x.WriterImageFilesId, x.WritersId });
                    table.ForeignKey(
                        name: "FK_WriterWriterImageFile_Files_WriterImageFilesId",
                        column: x => x.WriterImageFilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WriterWriterImageFile_Writers_WritersId",
                        column: x => x.WritersId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Headings_HeadingId",
                        column: x => x.HeadingId,
                        principalTable: "Headings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7755), "Burası Eğitim Kategorisidir.", true, "Eğitim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7758), "Burası Tiyatro Kategorisidir.", true, "Tiyatro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7760), "Burası Kitap Kategorisidir.", true, "Kitap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7761), "Burası Spor Kategorisidir.", true, "Spor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7763), "Burası Film Kategorisidir.", true, "Film", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7766), "Burası Dizi Kategorisidir.", true, "Dizi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "About", "CreatedDate", "Email", "FirstName", "IsActive", "LastName", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Yazılım Mühendisi, Frontend Developer", new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6979), "aliyildiz@gmail.com", "Ali", true, "Yıldız", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Senior Software Developer, Bolca Kitap Okur", new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6982), "mehmet@gmail.com", "Mehmet", true, "Çınar", "11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Tiyatro, Filtre Kahve", new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6984), "emel@gmail.com", "Emel", true, "Öztürk", "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Spor, Bisiklet, Dergiler ve Karikatürler", new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6986), "gizem@hotmail.com", "Gizem", true, "Yıldız", "10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Kahve vazgeçilmezim yanında bolca kod ile", new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6988), "asli@gmail.com", "Aslı", true, "Kaya", "00011", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Headings",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "IsActive", "Name", "UpdatedDate", "WriterId" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4618), true, "Breaking Bad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 5, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4621), true, "Green Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 3, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4622), true, "İtiraflarım", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 6, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4624), true, "La Casa De Papel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 2, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4625), true, "Venedik Taciri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "CreatedDate", "HeadingId", "IsActive", "UpdatedDate", "Value", "WriterId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2496), 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter White'ın efsane yaşam öyküsü", 3 },
                    { 2, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2498), 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Küçük Walter seni çok özledik keşke bu dizi devam etse", 4 },
                    { 3, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2500), 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bu film 2019 yılında Oscar ödülüne aday oldu ve Oscar ödülünü almayı başardı", 1 },
                    { 4, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2502), 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WÇok beğendiğim efsane bir film olmuş", 3 },
                    { 5, new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2503), 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatımda izlediğim en iyi 10 filmden biri oldu.", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutAboutImageFile_AboutsId",
                table: "AboutAboutImageFile",
                column: "AboutsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_HeadingId",
                table: "Contents",
                column: "HeadingId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_WriterId",
                table: "Contents",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Headings_CategoryId",
                table: "Headings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Headings_WriterId",
                table: "Headings",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_WriterWriterImageFile_WritersId",
                table: "WriterWriterImageFile",
                column: "WritersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutAboutImageFile");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "WriterWriterImageFile");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Headings");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
