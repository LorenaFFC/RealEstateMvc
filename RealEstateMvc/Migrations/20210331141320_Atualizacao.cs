using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateMvc.Migrations
{
    public partial class Atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultant_Department_DepartmentsId",
                table: "Consultant");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "Consultant",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultant_DepartmentsId",
                table: "Consultant",
                newName: "IX_Consultant_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultant_Department_DepartmentId",
                table: "Consultant",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultant_Department_DepartmentId",
                table: "Consultant");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Consultant",
                newName: "DepartmentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultant_DepartmentId",
                table: "Consultant",
                newName: "IX_Consultant_DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultant_Department_DepartmentsId",
                table: "Consultant",
                column: "DepartmentsId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
