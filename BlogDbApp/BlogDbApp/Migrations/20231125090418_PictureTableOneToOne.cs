using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogDbApp.Migrations
{
    public partial class PictureTableOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PictureId",
                table: "BlogPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_PictureId",
                table: "BlogPosts",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Pictures_PictureId",
                table: "BlogPosts",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Pictures_PictureId",
                table: "BlogPosts");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_PictureId",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "BlogPosts");
        }
    }
}
