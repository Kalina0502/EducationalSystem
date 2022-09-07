using Microsoft.EntityFrameworkCore.Migrations;

namespace JustDiscustIt.Data.Migrations
{
    public partial class modifyuser12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Messages",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "Receiver",
                table: "Messages",
                newName: "ReceiverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Messages",
                newName: "Sender");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Messages",
                newName: "Receiver");
        }
    }
}
