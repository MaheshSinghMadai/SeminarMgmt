using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarMgmt.Migrations
{
    public partial class NewOneee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Attendees",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeminarId",
                table: "Attendees",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
