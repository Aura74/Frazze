using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class dropdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "Phrases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Phrases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_CategoryId",
                table: "Phrases",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Application_CategoryId",
                table: "Phrases",
                column: "CategoryId",
                principalTable: "Application",
                principalColumn: "ApplicationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Application_CategoryId",
                table: "Phrases");

            migrationBuilder.DropIndex(
                name: "IX_Phrases_CategoryId",
                table: "Phrases");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "Phrases");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Phrases");
        }
    }
}
