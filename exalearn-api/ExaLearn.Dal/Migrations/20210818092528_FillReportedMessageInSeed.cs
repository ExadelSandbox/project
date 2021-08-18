using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class FillReportedMessageInSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Text",
                value: "Religion");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Text",
                value: "Coronavirus");

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Answer", "ReportedMessage" },
                values: new object[] { "was setled / contained", "misprint - was settled" });

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReportedMessage",
                value: "bad topic");

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReportedMessage",
                value: "Duplicate question");

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReportedMessage",
                value: "Duplicate question!");

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReportedMessage",
                value: "Duplicate question!!");

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReportedMessage",
                value: "Duplicate question");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c4291baa-08ff-4a5f-9395-833c24265737");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "921a43b7-d599-4e70-88c4-c2494a70ab01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "525efed2-6019-40f0-8509-aaafd932721c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a02289ce-f9d6-40c8-8c19-896baeab0398", "AQAAAAEAACcQAAAAENW3f+eJ3zB5VNI5rzdwqfoMtnIauyZHQMKetR49SB4QCeOgabOFQk3C8NhnNFSOaw==", "ac3ff6d1-549c-4ef6-b608-3de662236feb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16e6f348-1746-4745-8840-8f63d0b06538", "AQAAAAEAACcQAAAAEOQiQLvdbWk9plm5RCje4HFmTp5Q/06ZMCVQ0+u7lFRnMHC9Tyx1n+nH+CsottwiCg==", "64e2efd8-ce81-4e51-bff5-a017d0c79af9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96d5f6a7-2909-46ba-af8f-fbdfee5d6603", "AQAAAAEAACcQAAAAELIWEgvlRMbc978E2+XGlvbUwtmypvFPLRascFpF8smjfDfBue08mO7fNzj4yNCZ9w==", "649545a4-5148-4067-b9ce-311c6e324f48" });

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 18, 9, 47, 54, 870, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 18, 6, 47, 54, 872, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 17, 9, 47, 54, 872, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 111,
                column: "Text",
                value: "Coronavirus");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 114,
                column: "Text",
                value: "Childhood trends");

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Answer", "ReportedMessage" },
                values: new object[] { "was settled / contained", null });

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReportedMessage",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReportedMessage",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReportedMessage",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReportedMessage",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReportedMessage",
                value: null);
        }
    }
}
