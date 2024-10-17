using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_init_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "CreatedAt", "Name", "State" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(6973), "Devloper C#", 1 },
                    { 2L, new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(6986), "Devloper ASP.NET Core", 1 },
                    { 3L, new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(6987), "Devloper Angular", 1 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "JobTypeId", "Name", "State" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(7017), 1L, "Mohammed Al-Mesbahi", 1 },
                    { 2L, new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(7020), 2L, "Ali ali", 1 },
                    { 3L, new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(7021), 3L, "ali 2", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
