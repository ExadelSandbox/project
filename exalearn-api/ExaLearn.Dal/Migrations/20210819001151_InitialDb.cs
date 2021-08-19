using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799f8841-185b-4104-be8c-006bcf909606", "AQAAAAEAACcQAAAAEBfTlt3fwfQE6yduZPBVF5VRMItNU0uGg+Xd6qA+1LP6J1IMsgTbpbI5Raa4E2IyKg==", "40a3d50e-98f1-406f-9db9-402e9c598db4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e41bee8-216e-4fd1-8734-e34fed08de61", "AQAAAAEAACcQAAAAEBKkMrUorLdlHrBo1jZg3dF1F2kYRkJd6H8WXzL4izsPljhG/KCtqUkUENC3DhbUgA==", "6bbba655-7afc-4b52-8438-a7a74e952668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3845f07-1f00-468f-9ef7-5c7298693d6f", "AQAAAAEAACcQAAAAEEqd5mw76R3mhGKiyFDXZ10iJTc5tXBBAX1VSfJ08/YLmT9dCE/Iu0iZjp80yCgfyA==", "67772604-525d-413d-8571-70c241bd98cd" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "011fc426-20a0-47b5-926a-8994841d4f86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "106a4044-5d29-4c13-824a-29bd03ce341f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f2d6df6f-fa4b-4c57-8ffe-fe426db98766");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2233203-add2-49ac-ad75-af71fdced878", "AQAAAAEAACcQAAAAEOiowtYsy1fWIqicIeJ1TQWWhGKIS/wAsMJfl5CXwDYYZAsh7Q++QVFxa0JJZ9tw9A==", "3a3db4ba-4766-4f90-809d-bfbbc3695225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49294b0-6fce-45d4-a45a-c103224f96c2", "AQAAAAEAACcQAAAAEKilSgvyaRzfylgJhHdoYeVUobD4BFO9fq2za5C08kQdjRJEwIsvGtGklbnT2CC3Kw==", "c32908d6-4ab8-41ff-bff9-b4c2a6a8bf6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44978b81-957a-4631-8157-b7f45f90829f", "AQAAAAEAACcQAAAAEH58MqH2kRBhZ8Pfn/m3ATLxjnzLgMrpy+ZmvPQOdkML9XPbBGJ+u6JQYrwKlNGSfQ==", "b1138063-447d-46e6-bfe8-c5e6554bac11" });

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 18, 12, 25, 27, 469, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 18, 9, 25, 27, 470, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 17, 12, 25, 27, 470, DateTimeKind.Local).AddTicks(5000));
        }
    }
}
