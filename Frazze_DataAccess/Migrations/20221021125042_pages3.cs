using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class pages3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageId",
                table: "Phrases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_PageId",
                table: "Phrases",
                column: "PageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Page_PageId",
                table: "Phrases",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Page_PageId",
                table: "Phrases");

            migrationBuilder.DropIndex(
                name: "IX_Phrases_PageId",
                table: "Phrases");

            migrationBuilder.DropColumn(
                name: "PageId",
                table: "Phrases");
        }
    }
}
