using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAPI.Migrations
{
    public partial class maisuma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    EntryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntryTitle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryDescr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.EntryId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "EntryDate", "EntryDescr", "EntryTitle" },
                values: new object[] { 1, new DateTime(1996, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Presidente da China morre abrindo caminho para democratização", "Morte de Xim" });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "EntryDate", "EntryDescr", "EntryTitle" },
                values: new object[] { 2, new DateTime(1998, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uma tempestada se aproxima do litoral", "Tempestade a Vista" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entries");
        }
    }
}
