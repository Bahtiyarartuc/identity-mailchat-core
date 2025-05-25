using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityChatEmailNight.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderEmail",
                table: "Messages",
                newName: "SenderMail");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmail",
                table: "Messages",
                newName: "ReceiverMail");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "SenderMail",
                table: "Messages",
                newName: "SenderEmail");

            migrationBuilder.RenameColumn(
                name: "ReceiverMail",
                table: "Messages",
                newName: "ReceiverEmail");
        }
    }
}
