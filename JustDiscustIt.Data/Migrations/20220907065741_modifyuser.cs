using Microsoft.EntityFrameworkCore.Migrations;

namespace JustDiscustIt.Data.Migrations
{
    public partial class modifyuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageLevel",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobby_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobby_UserId",
                table: "Hobby",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageLevel",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
