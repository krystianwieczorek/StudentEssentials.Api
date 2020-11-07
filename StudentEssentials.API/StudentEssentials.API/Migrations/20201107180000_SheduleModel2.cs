using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class SheduleModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId",
                table: "SubjectToShedules");

            migrationBuilder.DropTable(
                name: "Shedules");

            migrationBuilder.DropIndex(
                name: "IX_SubjectToShedules_SheduleId",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "SheduleId",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "SheduleId",
                table: "Groups");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SheduleId",
                table: "SubjectToShedules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SheduleId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Shedules",
                columns: table => new
                {
                    SheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shedules", x => x.SheduleId);
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "SheduleId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Shedules",
                column: "SheduleId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToShedules_SheduleId",
                table: "SubjectToShedules",
                column: "SheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId",
                table: "SubjectToShedules",
                column: "SheduleId",
                principalTable: "Shedules",
                principalColumn: "SheduleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
