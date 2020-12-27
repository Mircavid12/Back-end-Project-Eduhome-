using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CreateCoursesTableDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursePurpose = table.Column<string>(nullable: true),
                    PurposeDescription = table.Column<string>(nullable: true),
                    CourseDetailTitle1 = table.Column<string>(nullable: true),
                    Description1 = table.Column<string>(nullable: true),
                    CourseDetailTitle2 = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true),
                    CourseDetailTitle3 = table.Column<string>(nullable: true),
                    Description3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CourseFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    ClassDuration = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    StudentsCount = table.Column<string>(nullable: true),
                    Assestments = table.Column<string>(nullable: true),
                    CourseFee = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CourseDetailsId = table.Column<int>(nullable: false),
                    CourseFeaturesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Courses_CourseDetails_CourseDetailsId",
                        column: x => x.CourseDetailsId,
                        principalTable: "CourseDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_CourseFeatures_CourseFeaturesId",
                        column: x => x.CourseFeaturesId,
                        principalTable: "CourseFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseDetailsId",
                table: "Courses",
                column: "CourseDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFeaturesId",
                table: "Courses",
                column: "CourseFeaturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CourseDetails");

            migrationBuilder.DropTable(
                name: "CourseFeatures");
        }
    }
}
