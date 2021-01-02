using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduhome.Migrations
{
    public partial class CreateSpeakerForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeaker_Events_Eventsid",
                table: "EventSpeaker");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeaker_Speakers_Speakersid",
                table: "EventSpeaker");

            migrationBuilder.DropIndex(
                name: "IX_EventSpeaker_Eventsid",
                table: "EventSpeaker");

            migrationBuilder.DropIndex(
                name: "IX_EventSpeaker_Speakersid",
                table: "EventSpeaker");

            migrationBuilder.DropColumn(
                name: "Eventsid",
                table: "EventSpeaker");

            migrationBuilder.DropColumn(
                name: "Speakersid",
                table: "EventSpeaker");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeaker_EventId",
                table: "EventSpeaker",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeaker_SpeakerId",
                table: "EventSpeaker",
                column: "SpeakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeaker_Events_EventId",
                table: "EventSpeaker",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeaker_Speakers_SpeakerId",
                table: "EventSpeaker",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeaker_Events_EventId",
                table: "EventSpeaker");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeaker_Speakers_SpeakerId",
                table: "EventSpeaker");

            migrationBuilder.DropIndex(
                name: "IX_EventSpeaker_EventId",
                table: "EventSpeaker");

            migrationBuilder.DropIndex(
                name: "IX_EventSpeaker_SpeakerId",
                table: "EventSpeaker");

            migrationBuilder.AddColumn<int>(
                name: "Eventsid",
                table: "EventSpeaker",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Speakersid",
                table: "EventSpeaker",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeaker_Eventsid",
                table: "EventSpeaker",
                column: "Eventsid");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeaker_Speakersid",
                table: "EventSpeaker",
                column: "Speakersid");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeaker_Events_Eventsid",
                table: "EventSpeaker",
                column: "Eventsid",
                principalTable: "Events",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeaker_Speakers_Speakersid",
                table: "EventSpeaker",
                column: "Speakersid",
                principalTable: "Speakers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
