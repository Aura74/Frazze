using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    public partial class pages6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Page_PageId",
                table: "Phrases");

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "Phrases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Page_PageId",
                table: "Phrases",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phrases_Page_PageId",
                table: "Phrases");

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "Phrases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Phrases_Page_PageId",
                table: "Phrases",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
