using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9182), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9195), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9199), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9538), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9539), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9541), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9542), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9437), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9437), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9440), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9440), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9442), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9443), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9445), new DateTime(2025, 11, 27, 17, 29, 58, 998, DateTimeKind.Local).AddTicks(9446), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
