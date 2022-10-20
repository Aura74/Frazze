using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class dropdown2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Application_CategoryId",
                table: "Phrases");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Phrases",
                newName: "ApplicationID");

            migrationBuilder.RenameIndex(
                name: "IX_Phrases_CategoryId",
                table: "Phrases",
                newName: "IX_Phrases_ApplicationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Application_ApplicationID",
                table: "Phrases",
                column: "ApplicationID",
                principalTable: "Application",
                principalColumn: "ApplicationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Application_ApplicationID",
                table: "Phrases");

            migrationBuilder.RenameColumn(
                name: "ApplicationID",
                table: "Phrases",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Phrases_ApplicationID",
                table: "Phrases",
                newName: "IX_Phrases_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Application_CategoryId",
                table: "Phrases",
                column: "CategoryId",
                principalTable: "Application",
                principalColumn: "ApplicationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
