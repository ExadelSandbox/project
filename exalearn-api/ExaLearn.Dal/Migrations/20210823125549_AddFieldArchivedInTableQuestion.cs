using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class AddFieldArchivedInTableQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Archived",
                table: "Questions",
                type: "smallint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "af1b716c-6f52-4a7c-b66c-038e4395411f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5bff6b4f-2efb-4ef1-8078-81139d75d54a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "94296781-4e1d-47e9-a9a4-747c67cb4bf7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "LevelType", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaa9b76a-76c6-48ec-b1eb-db9319e2b115", 1, "AQAAAAEAACcQAAAAEOzlSRH9S0BUugv0haaZiScKTCc5wFhi5BL4ROfZqqqMJPIRB91MEIhohrNoQ93O6Q==", "a6472bac-bcde-4ef2-83fc-b84662f34055" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "LevelType", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74509db2-5da2-4840-9d3c-2c52dd5a71c0", 3, "AQAAAAEAACcQAAAAEHS0P7DJ7hEzJ/MAn1hoJ0DopHWwV4UNW3wAvdRjKXAUkjYBmRluZe66xd4Uf/ntnQ==", "030efabe-1410-40d7-96b4-edb9da1437a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "LevelType", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3619f90-9032-491e-8cd8-0a3d12ea1a4b", 4, "AQAAAAEAACcQAAAAEH9P1BGY1c8a4g69km5o24RzTn1J29hg3jr7MhnPk+nTtmOlY9b1NYNkyWqshZxpHQ==", "72fba11a-10a5-4d83-90a0-f77df237d3f8" });

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 23, 15, 55, 48, 396, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 23, 12, 55, 48, 398, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 22, 15, 55, 48, 398, DateTimeKind.Local).AddTicks(4438));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archived",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b7f172b8-82b0-4057-b374-00b8379e2388");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2a1175c6-b664-4b35-a562-534504d7b41d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1084c0e7-7063-4978-812f-087576cfdcea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "LevelType", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799f8841-185b-4104-be8c-006bcf909606", null, "AQAAAAEAACcQAAAAEBfTlt3fwfQE6yduZPBVF5VRMItNU0uGg+Xd6qA+1LP6J1IMsgTbpbI5Raa4E2IyKg==", "40a3d50e-98f1-406f-9db9-402e9c598db4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "LevelType", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e41bee8-216e-4fd1-8734-e34fed08de61", null, "AQAAAAEAACcQAAAAEBKkMrUorLdlHrBo1jZg3dF1F2kYRkJd6H8WXzL4izsPljhG/KCtqUkUENC3DhbUgA==", "6bbba655-7afc-4b52-8438-a7a74e952668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "LevelType", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3845f07-1f00-468f-9ef7-5c7298693d6f", null, "AQAAAAEAACcQAAAAEEqd5mw76R3mhGKiyFDXZ10iJTc5tXBBAX1VSfJ08/YLmT9dCE/Iu0iZjp80yCgfyA==", "67772604-525d-413d-8571-70c241bd98cd" });

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 19, 3, 11, 49, 805, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 19, 0, 11, 49, 806, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 18, 3, 11, 49, 806, DateTimeKind.Local).AddTicks(9403));
        }
    }
}
