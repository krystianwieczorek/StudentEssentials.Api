using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class SheduleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId",
                table: "SubjectToShedules");

            migrationBuilder.AlterColumn<int>(
                name: "SheduleId",
                table: "SubjectToShedules",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "SubjectToShedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 1,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 2,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 3,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 4,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 5,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 6,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 7,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 8,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 9,
                columns: new[] { "GroupId", "SheduleId" },
                values: new object[] { 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToShedules_GroupId",
                table: "SubjectToShedules",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectToShedules_Groups_GroupId",
                table: "SubjectToShedules",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId",
                table: "SubjectToShedules",
                column: "SheduleId",
                principalTable: "Shedules",
                principalColumn: "SheduleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Groups_GroupId",
                table: "SubjectToShedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId",
                table: "SubjectToShedules");

            migrationBuilder.DropIndex(
                name: "IX_SubjectToShedules_GroupId",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "SubjectToShedules");

            migrationBuilder.AlterColumn<int>(
                name: "SheduleId",
                table: "SubjectToShedules",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 1,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 2,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 3,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 4,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 5,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 6,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 7,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 8,
                column: "SheduleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 9,
                column: "SheduleId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId",
                table: "SubjectToShedules",
                column: "SheduleId",
                principalTable: "Shedules",
                principalColumn: "SheduleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
