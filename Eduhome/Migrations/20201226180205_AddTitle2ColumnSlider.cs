using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class AddTitle2ColumnSlider : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
