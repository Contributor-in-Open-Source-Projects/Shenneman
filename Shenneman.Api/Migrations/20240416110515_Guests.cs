using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shenneman.Api.Migrations
{
    /// <inheritdoc />
    public partial class Guests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBrith = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "DateOfBrith", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 1, "Guest", new DateTime(2024, 4, 16, 16, 5, 14, 900, DateTimeKind.Local).AddTicks(6604), "Guest", "Guest", 0, "Guest", "1234567890" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
