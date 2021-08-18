using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ExaLearn.Dal.Migrations
{
    public partial class RemoveReportTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Reports_ReportId",
                table: "UserAnswers");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_ReportId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "UserAnswers");

            migrationBuilder.AddColumn<string>(
                name: "ReportedMessage",
                table: "UserAnswers",
                type: "text",
                nullable: true);

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
                keyValue: 11,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Ffsihit0jhcp001.mp3?alt=media&token=392ea30a-d853-4460-9f6f-6ba37735ad9f");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fegj9gccucy6002.mp3?alt=media&token=8d6ade0a-cc10-4ba4-928d-77be9e5a52b1");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 88,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 89,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 90,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 92,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 93,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 95,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2F7n5u1s3obuk004.mp3?alt=media&token=f2876c1c-6180-4962-831e-9ac4c8f22348");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 136,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 137,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 138,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 139,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 140,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 141,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 142,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 143,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 144,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 145,
                column: "FileUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Feapm7bsjp3i005.mp3?alt=media&token=31f5b99b-f8ac-4ee2-bd7f-cca5806df680");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportedMessage",
                table: "UserAnswers");

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "UserAnswers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "098cf1a6-74dc-4e29-b69e-9b6122cb373a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d5fc0eab-2632-4474-a08f-a21e2718d189");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f5dcf108-af85-4c4b-af51-87b71cf2e64b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e67761fe-26da-4e91-935a-cca53e266699", "AQAAAAEAACcQAAAAEBDvca/13nmbUx5B1wG0TDXqJTdvmaRVuAwZOKyo5bedOsbXK7C6xwb8jxnGOpFwTg==", "f2bc6739-bf3f-4c76-91df-58bace81b697" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4568637f-2388-48ea-bcf4-8580091e0c94", "AQAAAAEAACcQAAAAEP5iWszwWAhGgsabTKa2fOGYHfBKhXRwzSlp/vkqzR+9O5xVTnFdn1hj47uOH/xg7w==", "23e0c9f2-cfd4-4e9b-819a-f7fcc243017b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee363ec-49b1-4fd8-b855-71fdfac745fb", "AQAAAAEAACcQAAAAENV7pB12oBF5BbLNb0b1wiGn9bVDa89VIGEEtzdZrrz7mBR0RYPiIU9ODzX7//M0kg==", "40ce7f85-0ca2-4130-87fc-b2d853f1540c" });

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 17, 14, 37, 0, 520, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 17, 11, 37, 0, 522, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "PassedTests",
                keyColumn: "Id",
                keyValue: 3,
                column: "PassedTestDate",
                value: new DateTime(2021, 8, 16, 14, 37, 0, 522, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 88,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 89,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 90,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 92,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 93,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 95,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 136,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 137,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 138,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 139,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 140,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 141,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 142,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 143,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 144,
                column: "FileUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 145,
                column: "FileUrl",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_ReportId",
                table: "UserAnswers",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_QuestionId",
                table: "Reports",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Reports_ReportId",
                table: "UserAnswers",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
