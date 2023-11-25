using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogDbApp.Migrations
{
    public partial class PicturesOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "BlogPostId",
                table: "Pictures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_BlogPostId",
                table: "Pictures",
                column: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_BlogPosts_BlogPostId",
                table: "Pictures",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_BlogPosts_BlogPostId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_BlogPostId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "Pictures");

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
    }
}
