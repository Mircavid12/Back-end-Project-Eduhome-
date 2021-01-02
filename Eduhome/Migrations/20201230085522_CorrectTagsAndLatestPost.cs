using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CorrectTagsAndLatestPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Tags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coursesid",
                table: "Tags",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Blogsid",
                table: "LatestPosts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "LatestPosts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coursesid",
                table: "LatestPosts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Coursesid",
                table: "Tags",
                column: "Coursesid");

            migrationBuilder.CreateIndex(
                name: "IX_LatestPosts_Blogsid",
                table: "LatestPosts",
                column: "Blogsid");

            migrationBuilder.CreateIndex(
                name: "IX_LatestPosts_Coursesid",
                table: "LatestPosts",
                column: "Coursesid");

            migrationBuilder.AddForeignKey(
                name: "FK_LatestPosts_Blogs_Blogsid",
                table: "LatestPosts",
                column: "Blogsid",
                principalTable: "Blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LatestPosts_Courses_Coursesid",
                table: "LatestPosts",
                column: "Coursesid",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Courses_Coursesid",
                table: "Tags",
                column: "Coursesid",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Blogs_Blogsid",
                table: "LatestPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Courses_Coursesid",
                table: "LatestPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Courses_Coursesid",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_Coursesid",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_Blogsid",
                table: "LatestPosts");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_Coursesid",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Coursesid",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Blogsid",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "Coursesid",
                table: "LatestPosts");
        }
    }
}
