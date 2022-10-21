using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class dropdownCulture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CultId",
                table: "Phrases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Culture",
                columns: table => new
                {
                    CultureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Culture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culture", x => x.CultureID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_CultId",
                table: "Phrases",
                column: "CultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Culture_CultId",
                table: "Phrases",
                column: "CultId",
                principalTable: "Culture",
                principalColumn: "CultureID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Culture_CultId",
                table: "Phrases");

            migrationBuilder.DropTable(
                name: "Culture");

            migrationBuilder.DropIndex(
                name: "IX_Phrases_CultId",
                table: "Phrases");

            migrationBuilder.DropColumn(
                name: "CultId",
                table: "Phrases");
        }
    }
}
