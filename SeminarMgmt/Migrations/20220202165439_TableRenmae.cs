using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarMgmt.Migrations
{
    public partial class TableRenmae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Attendees",
                newName: "Phonenumber");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Attendees",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Attendees",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Attendees",
                newName: "Emailaddress");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Attendees",
                newName: "UserID");

            migrationBuilder.AlterColumn<string>(
                name: "Phonenumber",
                table: "Attendees",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phonenumber",
                table: "Attendees",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Attendees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Attendees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Emailaddress",
                table: "Attendees",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Attendees",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Attendees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
