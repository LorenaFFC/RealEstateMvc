using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateMvc.Migrations
{
    public partial class CorrecaoColunaDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultant_Department_DepartmentId",
                table: "Consultant");

            migrationBuilder.DropColumn(
                name: "DeparmentId",
                table: "Consultant");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Consultant",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultant_Department_DepartmentId",
                table: "Consultant",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultant_Department_DepartmentId",
                table: "Consultant");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Consultant",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DeparmentId",
                table: "Consultant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultant_Department_DepartmentId",
                table: "Consultant",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
