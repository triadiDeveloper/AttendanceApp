using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeIdforIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                schema: "Identity",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_EmployeeId",
                schema: "Identity",
                table: "ApplicationUsers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Employee_EmployeeId",
                schema: "Identity",
                table: "ApplicationUsers",
                column: "EmployeeId",
                principalSchema: "HumanResource",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Employee_EmployeeId",
                schema: "Identity",
                table: "ApplicationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_EmployeeId",
                schema: "Identity",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "Identity",
                table: "ApplicationUsers");
        }
    }
}
