using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class NoticeBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NoticeBoards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    NoticeTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
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
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingleNoticeRights", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoticeBoards");

            migrationBuilder.DropTable(
                name: "SingleNoticeRights");
        }
    }
}
