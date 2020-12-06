using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class AddedNewColumnClassroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Classroom",
                table: "SubjectToShedules",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classroom",
                table: "SubjectToShedules");
        }
    }
}
