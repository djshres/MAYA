using Microsoft.EntityFrameworkCore.Migrations;

namespace Maya.API.Migrations
{
    public partial class ChangedKnownAs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KonwnAs",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "KnownAs",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KnownAs",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "KonwnAs",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
