using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class ChangedUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GroupId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId1",
                table: "Users",
                column: "GroupId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupId1",
                table: "Users",
                column: "GroupId1",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
