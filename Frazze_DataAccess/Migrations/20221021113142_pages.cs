using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class pages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Culture",
                table: "Phrases");

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Page_Application_ApplicationID",
                        column: x => x.ApplicationID,
                        principalTable: "Application",
                        principalColumn: "ApplicationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Page_ApplicationID",
                table: "Page",
                column: "ApplicationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.AddColumn<string>(
                name: "Culture",
                table: "Phrases",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
