using Microsoft.EntityFrameworkCore.Migrations;

namespace tenant_turner.Migrations
{
    public partial class FifthMigrationForUserBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "staff_bio",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "staff_bio",
                table: "Users");
        }
    }
}
