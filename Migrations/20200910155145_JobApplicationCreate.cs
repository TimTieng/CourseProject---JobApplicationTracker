using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TiengInClassWebApp.Migrations
{
    public partial class JobApplicationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    jobRequisitionNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobTitle = table.Column<string>(nullable: false),
                    hiringCompany = table.Column<string>(nullable: false),
                    jobLocation = table.Column<string>(nullable: false),
                    applicationSubmissionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.jobRequisitionNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
