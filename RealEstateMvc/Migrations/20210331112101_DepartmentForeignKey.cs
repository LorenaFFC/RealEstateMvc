using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateMvc.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeparmentId",
                table: "Consultant",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeparmentId",
                table: "Consultant");
        }
    }
}
