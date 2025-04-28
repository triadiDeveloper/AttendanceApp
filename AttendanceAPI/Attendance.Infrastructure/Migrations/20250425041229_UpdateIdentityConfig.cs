using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentityConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserClaims_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLogins_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRoles_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserTokens_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "Identity",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Identity",
                newName: "ApplicationUsers",
                newSchema: "Identity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                schema: "Identity",
                table: "ApplicationUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserClaims_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserClaims",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLogins_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserLogins",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRoles_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserRoles",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserTokens_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserTokens",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserClaims_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLogins_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRoles_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserTokens_ApplicationUsers_UserId",
                schema: "Identity",
                table: "ApplicationUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                schema: "Identity",
                table: "ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                schema: "Identity",
                newName: "Users",
                newSchema: "Identity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "Identity",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserClaims_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserClaims",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLogins_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserLogins",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRoles_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserRoles",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserTokens_Users_UserId",
                schema: "Identity",
                table: "ApplicationUserTokens",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
