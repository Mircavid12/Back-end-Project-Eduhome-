using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class IsDeletedColumnAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SingleNoticeRights",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NoticeBoards",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SingleNoticeRights");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NoticeBoards");
        }
    }
}
