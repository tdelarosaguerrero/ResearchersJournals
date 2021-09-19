using Microsoft.EntityFrameworkCore.Migrations;

namespace ResearchersJournals.Web.Infrastructure.Data.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Researchers",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Researchers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Researchers");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Researchers",
                newName: "CreateDate");
        }
    }
}
