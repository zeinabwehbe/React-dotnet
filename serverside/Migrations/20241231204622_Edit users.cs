using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace serverside.Migrations
{
    /// <inheritdoc />
    public partial class Editusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Users",
                newName: "ReputationPoints");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { new DateTime(2024, 12, 31, 20, 46, 22, 241, DateTimeKind.Utc).AddTicks(4202), "user5@example.com", "iyyG6pzy6k61F/0eBrdPOZ5/7A/vkuO0gqbPLisJICM=", "Member", "UserFive" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { new DateTime(2024, 12, 31, 20, 46, 22, 241, DateTimeKind.Utc).AddTicks(4215), "user7@example.com", "WGCDbo8T/Jg3U5pZfUCGv8ApnlStkhSNVFOLXD/u+3w=", "Admin", "UserSeven" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ReputationPoints",
                table: "Users",
                newName: "MyProperty");
        }
    }
}
