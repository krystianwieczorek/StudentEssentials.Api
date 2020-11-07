using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class ChangedSubjectToSheduleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Subjects_SubjectId",
                table: "SubjectToShedules");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_SubjectToShedules_SubjectId",
                table: "SubjectToShedules");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SubjectToShedules",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Profesor",
                table: "SubjectToShedules",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SheduleId1",
                table: "SubjectToShedules",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 1,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Programowanie Webowe", "Kazimierz Kądka", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 2,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Programowanie Rozproszone", "Zbigniew Łysacz", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 3,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Sztuczna Inteligencja", "Zbigniew Nochal", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 4,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Grafika", "Bożena Aleksandrowicz", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 5,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Ping-Pong", "Adam Adamowicz", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 6,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Programowanie Niskopoziomowe", "Aleksandra Aleksandrowicz", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 7,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Programowanie Wysokopoziomowe", "Aleksandra Aleksandrowicz", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 8,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Algorytmika", "Paweł Pawłowski", 0 });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 9,
                columns: new[] { "Name", "Profesor", "SubjectId" },
                values: new object[] { "Big Data", "Aleksandra Aleksandrowicz", 0 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectToShedules_Shedules_SheduleId1",
                table: "SubjectToShedules");

            migrationBuilder.DropIndex(
                name: "IX_SubjectToShedules_SheduleId1",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "Profesor",
                table: "SubjectToShedules");

            migrationBuilder.DropColumn(
                name: "SheduleId1",
                table: "SubjectToShedules");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Profesor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name", "Profesor" },
                values: new object[] { 1, "Programowanie Webowe", "Kazimierz Kądka" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name", "Profesor" },
                values: new object[] { 2, "Programowanie Niskopoziomowe", "Aleksandra Aleksandrowicz" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name", "Profesor" },
                values: new object[] { 3, "Programowanie Rozproszone", "Zbigniew Łysacz" });

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 1,
                column: "SubjectId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 2,
                column: "SubjectId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 3,
                column: "SubjectId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 4,
                column: "SubjectId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 5,
                column: "SubjectId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 6,
                column: "SubjectId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 7,
                column: "SubjectId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 8,
                column: "SubjectId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 9,
                column: "SubjectId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToShedules_SubjectId",
                table: "SubjectToShedules",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectToShedules_Subjects_SubjectId",
                table: "SubjectToShedules",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
