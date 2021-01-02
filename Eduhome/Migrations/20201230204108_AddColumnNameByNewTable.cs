using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class AddColumnNameByNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Blogs_Blogsid",
                table: "LatestPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Courses_Coursesid",
                table: "LatestPosts");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_Blogsid",
                table: "LatestPosts");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_Coursesid",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "Blogsid",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "Coursesid",
                table: "LatestPosts");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Tags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Tags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "LatestPosts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "LatestPosts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogId",
                table: "Tags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_EventId",
                table: "Tags",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_LatestPosts_BlogId",
                table: "LatestPosts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_LatestPosts_CourseId",
                table: "LatestPosts",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_LatestPosts_EventId",
                table: "LatestPosts",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_LatestPosts_Blogs_BlogId",
                table: "LatestPosts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LatestPosts_Courses_CourseId",
                table: "LatestPosts",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LatestPosts_Events_EventId",
                table: "LatestPosts",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Blogs_BlogId",
                table: "Tags",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Events_EventId",
                table: "Tags",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Blogs_BlogId",
                table: "LatestPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Courses_CourseId",
                table: "LatestPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LatestPosts_Events_EventId",
                table: "LatestPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Blogs_BlogId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Events_EventId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_EventId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_BlogId",
                table: "LatestPosts");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_CourseId",
                table: "LatestPosts");

            migrationBuilder.DropIndex(
                name: "IX_LatestPosts_EventId",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "LatestPosts");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "LatestPosts");

            migrationBuilder.AddColumn<int>(
                name: "Blogsid",
                table: "LatestPosts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Coursesid",
                table: "LatestPosts",
                type: "int",
                nullable: true);

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
        }
    }
}
