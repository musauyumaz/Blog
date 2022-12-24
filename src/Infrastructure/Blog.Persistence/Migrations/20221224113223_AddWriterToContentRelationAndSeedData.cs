using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddWriterToContentRelationAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 24, 11, 32, 23, 4, DateTimeKind.Utc).AddTicks(7879), "Burası Eğitim Kategorisidir.", true, "Eğitim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 12, 24, 11, 32, 23, 4, DateTimeKind.Utc).AddTicks(7883), "Burası Tiyatro Kategorisidir.", true, "Tiyatro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 12, 24, 11, 32, 23, 4, DateTimeKind.Utc).AddTicks(7885), "Burası Kitap Kategorisidir.", true, "Kitap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 12, 24, 11, 32, 23, 4, DateTimeKind.Utc).AddTicks(7887), "Burası Spor Kategorisidir.", true, "Spor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 12, 24, 11, 32, 23, 4, DateTimeKind.Utc).AddTicks(7888), "Burası Film Kategorisidir.", true, "Film", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2022, 12, 24, 11, 32, 23, 4, DateTimeKind.Utc).AddTicks(7889), "Burası Dizi Kategorisidir.", true, "Dizi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "IsActive", "LastName", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(6309), "aliyildiz@gmail.com", "Ali", true, "Yıldız", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(6313), "mehmet@gmail.com", "Mehmet", true, "Çınar", "11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(6315), "emel@gmail.com", "Emel", true, "Öztürk", "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(6317), "gizem@hotmail.com", "Gizem", true, "Yıldız", "10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(6319), "asli@gmail.com", "Aslı", true, "Kaya", "00011", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Headings",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "IsActive", "Name", "UpdatedDate", "WriterId" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(4116), true, "Breaking Bad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 5, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(4119), true, "Green Book", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 3, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(4120), true, "İtiraflarım", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 6, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(4121), true, "La Casa De Papel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 2, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(4123), true, "Venedik Taciri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "CreatedDate", "HeadingId", "IsActive", "UpdatedDate", "Value", "WriterId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(2118), 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter White'ın efsane yaşam öyküsü", 3 },
                    { 2, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(2121), 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Küçük Walter seni çok özledik keşke bu dizi devam etse", 4 },
                    { 3, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(2123), 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bu film 2019 yılında Oscar ödülüne aday oldu ve Oscar ödülünü almayı başardı", 1 },
                    { 4, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(2124), 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WÇok beğendiğim efsane bir film olmuş", 3 },
                    { 5, new DateTime(2022, 12, 24, 11, 32, 23, 5, DateTimeKind.Utc).AddTicks(2126), 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatımda izlediğim en iyi 10 filmden biri oldu.", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_WriterId",
                table: "Contents",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Writers_WriterId",
                table: "Contents",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Writers_WriterId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_WriterId",
                table: "Contents");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Contents");
        }
    }
}
