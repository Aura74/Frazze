using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class dropdown5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Application_ApplicationID",
                table: "Phrases");

            migrationBuilder.DropIndex(
                name: "IX_Phrases_ApplicationID",
                table: "Phrases");

            migrationBuilder.DropColumn(
                name: "ApplicationID",
                table: "Phrases");

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_AppId",
                table: "Phrases",
                column: "AppId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Application_AppId",
                table: "Phrases",
                column: "AppId",
                principalTable: "Application",
                principalColumn: "ApplicationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Application_AppId",
                table: "Phrases");

            migrationBuilder.DropIndex(
                name: "IX_Phrases_AppId",
                table: "Phrases");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationID",
                table: "Phrases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_ApplicationID",
                table: "Phrases",
                column: "ApplicationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Application_ApplicationID",
                table: "Phrases",
                column: "ApplicationID",
                principalTable: "Application",
                principalColumn: "ApplicationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
