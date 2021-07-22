using Microsoft.EntityFrameworkCore.Migrations;

namespace SharkTDS.Migrations
{
    public partial class addTrashUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrashUrl",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrashUrl",
                table: "Settings");
        }
    }
}
