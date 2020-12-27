using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CreateCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    CourseDetailId = table.Column<int>(nullable: false),
                    CourseDetailsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categories_CourseDetails_CourseDetailsid",
                        column: x => x.CourseDetailsid,
                        principalTable: "CourseDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CourseDetailsid",
                table: "Categories",
                column: "CourseDetailsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
