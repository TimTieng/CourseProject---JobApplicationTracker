using Microsoft.EntityFrameworkCore.Migrations;

namespace TiengInClassWebApp.Migrations
{
    public partial class ApplicationNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "applicationNotes",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "applicationNotes",
                table: "Jobs");
        }
    }
}
