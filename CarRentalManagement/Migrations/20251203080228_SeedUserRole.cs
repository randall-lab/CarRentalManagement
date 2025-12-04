using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "857af49c-fb71-4d49-8c99-9d5909c556c9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPEp8PgELCLWlnMmo+DG0nlYlGDJtCZbQq5Ez3xu2jAgEvQTifOlLnaYgzt6HiRwEQ==", null, false, "684f6c16-188c-4059-9d1c-15b45213565e", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3449), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3470), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3935), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3939), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3762), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3765), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3768), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3771), new DateTime(2025, 12, 3, 16, 2, 27, 375, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(7864), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(7877), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8136), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8139), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8052), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8055), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8057), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8059), new DateTime(2025, 12, 3, 15, 22, 31, 958, DateTimeKind.Local).AddTicks(8060) });
        }
    }
}
