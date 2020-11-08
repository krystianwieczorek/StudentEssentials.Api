using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class CHangedGroupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_OwnerUserId",
                table: "Groups",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_OwnerUserId",
                table: "Groups",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_OwnerUserId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_OwnerUserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Groups");
        }
    }
}
