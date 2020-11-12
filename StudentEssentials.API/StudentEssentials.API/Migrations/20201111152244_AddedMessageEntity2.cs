using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEssentials.API.Migrations
{
    public partial class AddedMessageEntity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "UserId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "GroupId", "UserId" },
                values: new object[] { 3, "fesfsefsef MessageMessageMessaj46j4j45j54j4geMessage", 1, 2 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Content", "GroupId", "UserId" },
                values: new object[] { 2, "45545454 5757457457457547 454575475474", 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "UserId",
                value: 1);
        }
    }
}
