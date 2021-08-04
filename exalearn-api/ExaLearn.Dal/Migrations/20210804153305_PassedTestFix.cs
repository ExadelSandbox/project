using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class PassedTestFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassedTests_AssignTests_AssignTestId",
                table: "PassedTests");

            migrationBuilder.AlterColumn<int>(
                name: "AssignTestId",
                table: "PassedTests",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_PassedTests_AssignTests_AssignTestId",
                table: "PassedTests",
                column: "AssignTestId",
                principalTable: "AssignTests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassedTests_AssignTests_AssignTestId",
                table: "PassedTests");

            migrationBuilder.AlterColumn<int>(
                name: "AssignTestId",
                table: "PassedTests",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PassedTests_AssignTests_AssignTestId",
                table: "PassedTests",
                column: "AssignTestId",
                principalTable: "AssignTests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
