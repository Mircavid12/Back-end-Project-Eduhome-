using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CreateAllTablesDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "Sliders",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "Sliders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AboutIntros",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Image = table.Column<string>(maxLength: 150, nullable: false),
                    Description1 = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutIntros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AboutVideos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Video = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutVideos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderLogo = table.Column<string>(nullable: true),
                    FooterLogo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Info = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Chooses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description1 = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chooses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: false),
                    AddressLogo = table.Column<string>(maxLength: 150, nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
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
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    Day = table.Column<int>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LatestPosts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestPosts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NoticeBoards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SingleNoticeRights",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingleNoticeRights", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BlogDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Info = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description1 = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true),
                    Description3 = table.Column<string>(nullable: true),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    BlogsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_BlogDetails_Blogs_BlogsId",
                        column: x => x.BlogsId,
                        principalTable: "Blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    CourseFee = table.Column<double>(nullable: false),
                    About = table.Column<string>(nullable: true),
                    Apply = table.Column<string>(nullable: true),
                    Certification = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseFeatures_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description1 = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true),
                    Description3 = table.Column<string>(nullable: true),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EventsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventDetails_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teacherBios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    TeachersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacherBios", x => x.id);
                    table.ForeignKey(
                        name: "FK_teacherBios_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeacherDetails_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EventDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Speakers_EventDetails_EventDetailsId",
                        column: x => x.EventDetailsId,
                        principalTable: "EventDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    TeacherDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ContactInfos_TeacherDetails_TeacherDetailsId",
                        column: x => x.TeacherDetailsId,
                        principalTable: "TeacherDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Percentage = table.Column<double>(nullable: false),
                    TeacherDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.id);
                    table.ForeignKey(
                        name: "FK_Skills_TeacherDetails_TeacherDetailsId",
                        column: x => x.TeacherDetailsId,
                        principalTable: "TeacherDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogsId",
                table: "BlogDetails",
                column: "BlogsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_TeacherDetailsId",
                table: "ContactInfos",
                column: "TeacherDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeatures_CourseId",
                table: "CourseFeatures",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_EventsId",
                table: "EventDetails",
                column: "EventsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherDetailsId",
                table: "Skills",
                column: "TeacherDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_EventDetailsId",
                table: "Speakers",
                column: "EventDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_teacherBios_TeachersId",
                table: "teacherBios",
                column: "TeachersId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutIntros");

            migrationBuilder.DropTable(
                name: "AboutVideos");

            migrationBuilder.DropTable(
                name: "Bios");

            migrationBuilder.DropTable(
                name: "BlogDetails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Chooses");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CourseFeatures");

            migrationBuilder.DropTable(
                name: "LatestPosts");

            migrationBuilder.DropTable(
                name: "NoticeBoards");

            migrationBuilder.DropTable(
                name: "SingleNoticeRights");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "teacherBios");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "TeacherDetails");

            migrationBuilder.DropTable(
                name: "EventDetails");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
