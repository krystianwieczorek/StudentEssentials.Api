using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class IdentityTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    SheduleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Shedules",
                columns: table => new
                {
                    SheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shedules", x => x.SheduleId);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Profesor = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectToShedules",
                columns: table => new
                {
                    SubjectToSheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(maxLength: 50, nullable: false),
                    EndTime = table.Column<TimeSpan>(maxLength: 50, nullable: false),
                    SheduleDay = table.Column<int>(maxLength: 50, nullable: false),
                    SheduleId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectToShedules", x => x.SubjectToSheduleId);
                    table.ForeignKey(
                        name: "FK_SubjectToShedules_Shedules_SheduleId",
                        column: x => x.SheduleId,
                        principalTable: "Shedules",
                        principalColumn: "SheduleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectToShedules_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name", "SheduleId", "UserId" },
                values: new object[] { 1, "Informatyka I-go st sem.1 gr. dziekańska 6 lab. 11", 1, 1 });

            migrationBuilder.InsertData(
                table: "Shedules",
                column: "SheduleId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name", "Profesor" },
                values: new object[,]
                {
                    { 1, "Programowanie Webowe", "Kazimierz Kądka" },
                    { 2, "Programowanie Niskopoziomowe", "Aleksandra Aleksandrowicz" },
                    { 3, "Programowanie Rozproszone", "Zbigniew Łysacz" }
                });

            migrationBuilder.InsertData(
                table: "SubjectToShedules",
                columns: new[] { "SubjectToSheduleId", "EndTime", "SheduleDay", "SheduleId", "StartTime", "SubjectId" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 9, 0, 0, 0), 1, 1, new TimeSpan(0, 7, 0, 0, 0), 1 },
                    { 4, new TimeSpan(0, 9, 0, 0, 0), 2, 1, new TimeSpan(0, 7, 0, 0, 0), 1 },
                    { 2, new TimeSpan(0, 11, 0, 0, 0), 1, 1, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 5, new TimeSpan(0, 11, 0, 0, 0), 2, 1, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 3, new TimeSpan(0, 12, 0, 0, 0), 1, 1, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 6, new TimeSpan(0, 12, 0, 0, 0), 2, 1, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 7, new TimeSpan(0, 12, 0, 0, 0), 2, 1, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 8, new TimeSpan(0, 12, 0, 0, 0), 3, 1, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 9, new TimeSpan(0, 12, 0, 0, 0), 5, 1, new TimeSpan(0, 11, 0, 0, 0), 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "GroupId", "LastName", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "test@test.com", "Test", 1, "User", "test", 0 },
                    { 2, "test2@test.com", "Test2", 1, "User2", "test", 0 },
                    { 3, "test3@test.com", "Test3", 1, "User3", "test", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToShedules_SheduleId",
                table: "SubjectToShedules",
                column: "SheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectToShedules_SubjectId",
                table: "SubjectToShedules",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectToShedules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Shedules");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
