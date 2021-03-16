using Microsoft.EntityFrameworkCore.Migrations;

namespace tenant_turner.Migrations
{
    public partial class FourthMigrationForUserPics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Staff_pic",
                table: "Users",
                newName: "staff_pic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "staff_pic",
                table: "Users",
                newName: "Staff_pic");
        }
    }
}
