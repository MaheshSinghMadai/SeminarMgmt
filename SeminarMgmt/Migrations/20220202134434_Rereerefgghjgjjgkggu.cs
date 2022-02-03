using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarMgmt.Migrations
{
    public partial class Rereerefgghjgjjgkggu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Seminars_SeminarId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_SeminarId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "SeminarId",
                table: "Attendees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeminarId",
                table: "Attendees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_SeminarId",
                table: "Attendees",
                column: "SeminarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Seminars_SeminarId",
                table: "Attendees",
                column: "SeminarId",
                principalTable: "Seminars",
                principalColumn: "SeminarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
