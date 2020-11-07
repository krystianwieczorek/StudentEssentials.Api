using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class ChangedSubjectToSheduleModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SubjectToShedules");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "SubjectToShedules",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 1,
                column: "Subject",
                value: "Programowanie Webowe");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 2,
                column: "Subject",
                value: "Programowanie Rozproszone");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 3,
                column: "Subject",
                value: "Sztuczna Inteligencja");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 4,
                column: "Subject",
                value: "Grafika");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 5,
                column: "Subject",
                value: "Ping-Pong");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 6,
                column: "Subject",
                value: "Programowanie Niskopoziomowe");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 7,
                column: "Subject",
                value: "Programowanie Wysokopoziomowe");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 8,
                column: "Subject",
                value: "Algorytmika");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 9,
                column: "Subject",
                value: "Big Data");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "SubjectToShedules");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SubjectToShedules",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 1,
                column: "Name",
                value: "Programowanie Webowe");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 2,
                column: "Name",
                value: "Programowanie Rozproszone");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 3,
                column: "Name",
                value: "Sztuczna Inteligencja");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 4,
                column: "Name",
                value: "Grafika");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 5,
                column: "Name",
                value: "Ping-Pong");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 6,
                column: "Name",
                value: "Programowanie Niskopoziomowe");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 7,
                column: "Name",
                value: "Programowanie Wysokopoziomowe");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 8,
                column: "Name",
                value: "Algorytmika");

            migrationBuilder.UpdateData(
                table: "SubjectToShedules",
                keyColumn: "SubjectToSheduleId",
                keyValue: 9,
                column: "Name",
                value: "Big Data");
        }
    }
}
