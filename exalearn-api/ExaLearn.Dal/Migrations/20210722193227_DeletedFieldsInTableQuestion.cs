using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class DeletedFieldsInTableQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Questions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Questions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
