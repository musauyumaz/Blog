using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleToWriters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Writers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 149, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6562), "" });

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6580), "" });

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6582), "" });

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6588), "" });

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 1, 2, 17, 35, 17, 150, DateTimeKind.Utc).AddTicks(6601), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Writers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 710, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Headings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 1, 15, 58, 51, 711, DateTimeKind.Utc).AddTicks(6988));
        }
    }
}
