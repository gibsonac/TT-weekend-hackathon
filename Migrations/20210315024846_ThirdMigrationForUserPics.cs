using Microsoft.EntityFrameworkCore.Migrations;

namespace tenant_turner.Migrations
{
    public partial class ThirdMigrationForUserPics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Staff_pic",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Staff_pic",
                table: "Users");
        }
    }
}
