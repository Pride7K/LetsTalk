using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsTalk.Migrations
{
    public partial class IsOnline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Chat_ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ChatId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ChatId",
                table: "AspNetUsers",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Chat_ChatId",
                table: "AspNetUsers",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
