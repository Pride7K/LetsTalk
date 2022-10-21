using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsTalk.Migrations
{
    public partial class textlength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TextLength",
                table: "Message",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextLength",
                table: "Message");
        }
    }
}
