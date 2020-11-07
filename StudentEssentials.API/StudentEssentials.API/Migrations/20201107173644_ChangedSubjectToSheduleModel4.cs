using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class ChangedSubjectToSheduleModel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId1",
                table: "SubjectToShedules");

            migrationBuilder.DropIndex(
                name: "IX_SubjectToShedules_SheduleId1",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "SheduleId1",
                table: "SubjectToShedules");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SheduleId1",
                table: "SubjectToShedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToShedules_SheduleId1",
                table: "SubjectToShedules",
                column: "SheduleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId1",
                table: "SubjectToShedules",
                column: "SheduleId1",
                principalTable: "Shedules",
                principalColumn: "SheduleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
