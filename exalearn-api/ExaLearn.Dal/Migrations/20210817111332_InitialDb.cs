using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ExaLearn.Dal.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.Sql("CREATE PROCEDURE archiveexpiredassigntest(dateNow TIMESTAMP) language plpgsql AS $$ BEGIN UPDATE \"PassedTests\" SET \"Status\" = 4 FROM \"AssignTests\" WHERE \"PassedTests\".\"Status\" = 1 AND \"AssignTests\".\"ExpirationDate\" < dateNow AND \"PassedTests\".\"AssignTestId\" = \"AssignTests\".\"Id\"; END; $$");
            migrationBuilder.Sql("CREATE PROCEDURE archiveexpiredassignedtest() language plpgsql AS $$ BEGIN UPDATE \"AssignTests\" SET \"IsExpired\" = true FROM \"PassedTests\" WHERE \"PassedTests\".\"Status\" = 4 AND \"PassedTests\".\"AssignTestId\" = \"AssignTests\".\"Id\"; END; $$");
            migrationBuilder.Sql("CREATE PROCEDURE archivepassedassignedtest() language plpgsql AS $$ BEGIN UPDATE \"AssignTests\" SET \"Passed\" = true FROM \"PassedTests\" WHERE \"PassedTests\".\"Status\" = 2 AND \"PassedTests\".\"AssignTestId\" = \"AssignTests\".\"Id\"; END; $$");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    LevelType = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Grammar = table.Column<int>(type: "integer", nullable: false),
                    Audition = table.Column<int>(type: "integer", nullable: false),
                    Essay = table.Column<int>(type: "integer", nullable: true),
                    Speaking = table.Column<int>(type: "integer", nullable: true),
                    General = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LevelType = table.Column<int>(type: "integer", nullable: false),
                    FileUrl = table.Column<string>(type: "text", nullable: true),
                    QuestionType = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    AssignerId = table.Column<int>(type: "integer", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsExpired = table.Column<bool>(type: "boolean", nullable: false),
                    Passed = table.Column<bool>(type: "boolean", nullable: false),
                    LevelType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignTests_AspNetUsers_AssignerId",
                        column: x => x.AssignerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignTests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    IsCorrect = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "QuestionUserTest",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(type: "integer", nullable: false),
                    UserTestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionUserTest", x => new { x.QuestionsId, x.UserTestId });
                    table.ForeignKey(
                        name: "FK_QuestionUserTest_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionUserTest_UserTests_UserTestId",
                        column: x => x.UserTestId,
                        principalTable: "UserTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassedTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CheckerId = table.Column<int>(type: "integer", nullable: true),
                    AssignTestId = table.Column<int>(type: "integer", nullable: true),
                    UserTestId = table.Column<int>(type: "integer", nullable: true),
                    LevelType = table.Column<int>(type: "integer", nullable: false),
                    AssessmentId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PassedTestDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassedTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassedTests_AspNetUsers_CheckerId",
                        column: x => x.CheckerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PassedTests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassedTests_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PassedTests_AssignTests_AssignTestId",
                        column: x => x.AssignTestId,
                        principalTable: "AssignTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PassedTests_UserTests_UserTestId",
                        column: x => x.UserTestId,
                        principalTable: "UserTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PassedTestId = table.Column<int>(type: "integer", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    ReportId = table.Column<int>(type: "integer", nullable: true),
                    Answer = table.Column<string>(type: "text", nullable: true),
                    Assessment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswers_PassedTests_PassedTestId",
                        column: x => x.PassedTestId,
                        principalTable: "PassedTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 3, "0970c2cb-77cc-4a2a-acaa-97b73b734b5f", "Role", "Coach", "COACH" },
                    { 2, "af48bf35-087b-4136-b893-476fa4bef0fe", "Role", "Hr", "HR" },
                    { 1, "410183f0-e1a6-484c-bfe6-855c5064fb07", "Role", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LevelType", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 3, 0, "408bca61-ba49-4fae-850b-13a0bba2e797", "coachexa@mailnesia.com", false, "Joe", false, "Hart", null, true, null, "COACHEXA@MAILNESIA.COM", "COACHEXA@MAILNESIA.COM", "AQAAAAEAACcQAAAAEHRl/SeBW8mchwLnTQ2DJ3dihPHrCfvNHPo5HpFxOGiCorKC4Np4LLZylWOU7Yz2Gg==", null, false, "0f7c8478-d18a-46e3-8cab-21d703576ab9", false, "coachexa@mailnesia.com" },
                    { 1, 0, "7697b455-d764-4eb0-bf2b-256de70d0fd9", "userexa@mailnesia.com", false, "Gordon", false, "Banks", null, true, null, "USEREXA@MAILNESIA.COM", "USEREXA@MAILNESIA.COM", "AQAAAAEAACcQAAAAEC52JzFuSwo0BgBEwB9zxm4klI0oTqKMNVowDprIxGrDBjzErv6d7H7/LW04ox55LQ==", null, false, "3bee53a8-408f-4d62-8db5-90821a2bca6b", false, "userexa@mailnesia.com" },
                    { 2, 0, "08cc8123-c999-4ee0-9689-45aeedfe0119", "userexa@mailnesia.com", false, "David", false, "Seama", null, true, null, "HREXA@MAILNESIA.COM", "HREXA@MAILNESIA.COM", "AQAAAAEAACcQAAAAEPQZSEiQt5n7WQscd/zQpKXHOJembcDuzVffP+5IccCyKYsu0McC1lKNKctb7pVI9w==", null, false, "abca3838-c523-4883-8347-affe1f822160", false, "hrexa@mailnesia.com" }
                });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "Id", "Audition", "Essay", "General", "Grammar", "Speaking" },
                values: new object[,]
                {
                    { 1, 8, 0, 16, 8, 0 },
                    { 2, 8, 0, 18, 10, 0 },
                    { 3, 5, 0, 15, 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FileUrl", "LevelType", "QuestionType", "Text" },
                values: new object[,]
                {
                    { 5, null, 1, 1, "Joe ---- a good driver" },
                    { 102, null, 5, 1, "Julius Caesar ------ a great historian if the making of history ------ him the time and the inclination to write it." },
                    { 103, null, 5, 1, "Early in 1940, when Europe was already at war, Hitler ------  the sale of uranium from the Czech mines he ------ over." },
                    { 104, null, 5, 1, "Physics, as it ------ at the end of the nineteenth century, ------ to as classical physics." },
                    { 105, null, 5, 1, "Sometimes people select certain foods that they believe ------ their physical appearance and avoid those they believe ------ detrimental." },
                    { 106, null, 5, 1, "It is not unusual for advertising campaigns ------ even before the new products ------ onto the market." },
                    { 107, null, 5, 1, "Much health education in recent years ------ towards the view that heavy drinker ------  subject for amusement but for practical help." },
                    { 108, null, 5, 1, "Galileo originated the method of controlled experiment ------ now forms the basis of scientific investigation." },
                    { 109, null, 5, 1, "Unfortunately, the worlds forest ------ at such a rate that the remaining tropical rainforests ------ by the middle of the century." },
                    { 110, null, 5, 1, "The continuing controversy ------ in 1924 by P. Hubble, who found that the great spiral nebula in Andromeda ------ Cepheld variables." },
                    { 111, null, 5, 3, "Coronavirus" },
                    { 112, null, 5, 3, "Electric cars" },
                    { 113, null, 5, 3, "Rich world, poor world." },
                    { 114, null, 5, 3, "Childhood trends" },
                    { 115, null, 5, 3, "Parenting" },
                    { 101, null, 5, 1, "Until the eighteenth century comparative linguistic studies did not progress ------ beyond the stage where ancient Greek and Roman grammarians had left them." },
                    { 405, null, 4, 3, "Meaning of life" },
                    { 403, null, 4, 3, "Why we live on this earth?" },
                    { 116, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What was the Hacienda?" },
                    { 83, null, 4, 1, "I ------ an interview because Id worked there before." },
                    { 84, null, 4, 1, "When I asked what was wrong, ------" },
                    { 85, null, 4, 1, "Steven ------ the wallet." },
                    { 86, null, 4, 2, "What are the people discussing?" },
                    { 87, null, 4, 2, "What is the woman referring to when she states, that sounds like fun?" },
                    { 88, null, 4, 2, "Which duty does the man like the least?" },
                    { 89, null, 4, 2, "What is the talk mainly about?" },
                    { 90, null, 4, 2, "What is the woman referring to when she states, That was in 1883?" },
                    { 91, null, 4, 2, "In addition to Annie Oakley, which other famous person traveled with Buffalo Bill?" },
                    { 92, null, 4, 2, "What does the speaker mainly discuss?" },
                    { 93, null, 4, 2, "According to the professor, what is ragtime?" },
                    { 94, null, 4, 2, "What does the professor contrast in his lecture?" },
                    { 95, null, 4, 2, "What are the people discussing?" },
                    { 401, null, 4, 3, "What do you think about happiness" },
                    { 402, null, 4, 3, "Life after death" },
                    { 404, null, 4, 3, "tell us about Platos cave" },
                    { 117, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What was the Hacienda2?" },
                    { 118, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "The Northern Quarter had mills in the industrial era, but what is there now?" },
                    { 119, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What does Ella play?" },
                    { 139, null, 6, 2, "-------- a celebrity arrives in Istanbul, the first question reporters ask them is ------- they like Istanbul." },
                    { 140, null, 6, 2, "The results of last weekends poll have ------- to be announced and officials say it could be -------- week before they are." },
                    { 141, null, 6, 2, "She failed to get anyone to repair the taps for her at the weekend, -------- could she do it on her own." },
                    { 142, null, 6, 2, "The neutral mutation rate is known -------- widely along human chromosomes, -------- to mutational hot and cold regions." },
                    { 143, null, 6, 2, "You would not expect anyone -------- intelligent to make ------ stupid mistake, but he did so." },
                    { 144, null, 6, 2, "I dont suppose you are telling us the true version of the story, ----------?" },
                    { 138, null, 6, 2, "My mother is making a steady recovery from flu and ------- hospital by next week." },
                    { 145, null, 6, 2, "Some people argue that certain oriental relaxation techniques ------- yoga and meditation are extremely effective in the treatment of high blood pressure." },
                    { 147, null, 0, 3, "Do you think all citizens should be encouraged to do voluntary service overseas so as to understand the problems of poorer countries?" },
                    { 148, null, 0, 3, "What is the purpose of the misinformation?" },
                    { 149, null, 0, 3, "Do people tend to be more violent when they group together? (gangs / mobs / crowds)" },
                    { 150, null, 0, 3, "What are the worst consequences of a natural disaster?" },
                    { 2, null, 1, 1, "How many major verb tenses are in english?" },
                    { 1, null, 1, 1, "Capital of the England?" },
                    { 146, null, 0, 3, "Are electric cars better for the environment?" },
                    { 137, null, 6, 2, "The scientist who -------- Dolly the sheep, the worlds first cloned mammal, -------- a licence on Tuesday to clone human embryos for medical research." },
                    { 136, null, 6, 2, "A combination of imagination and determination -------- Peter -------- entirely new lines of research concerned with the way animals survive extreme environmental conditions" },
                    { 135, null, 6, 1, "If I -------- the choice of making either an oral or a written report, I -------- the second alternative." },
                    { 120, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "According to Ella, who spends more time in the studio?" },
                    { 121, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "Where was Ella born?" },
                    { 122, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "The Northern Quarter had mills in the industrial era, but what is there now2?" },
                    { 123, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What does Ella play2?" },
                    { 124, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "According to Ella, who spends more time in the studio2?" },
                    { 125, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "Where was Ella born2?" },
                    { 126, null, 6, 1, "Tourists -------- when large numbers of middle class people ------- to join the more wealthy aristocratic travellers." },
                    { 127, null, 6, 1, "The wounded hunter -------- on the ground for almost an hour when, coincidentally, he -------- by another hunter, who must have keen eyes" },
                    { 128, null, 6, 1, "As the tree was too high to climb, the mischievous boys ---------- their ball down only by throwing sticks at it." },
                    { 129, null, 6, 1, "Certain serious diseases can be successfully treated -------- detected in an initial stage." },
                    { 130, null, 6, 1, "---------- you have made minimal progress, it is by no means the kind of progress that you need to make." },
                    { 131, null, 6, 1, "Soils are the result of -------- interacting processes -------- bring different materials together." },
                    { 132, null, 6, 1, "Im ready to do ---------- I can do to help you - ------- your hardship." },
                    { 133, null, 6, 1, "Despite my insistence, Adam didnt tell me -------- he didnt like me and my family." },
                    { 134, null, 6, 1, "She keeps saying that she has got -------- patience with kids, but forgets that she didnt have -------- before she gave birth to her own kids." },
                    { 82, null, 4, 1, "I dont know when Helen ------ back." },
                    { 81, null, 4, 1, "Your eyes are red ------?" },
                    { 80, null, 4, 1, "We ------ to the tennis club since we moved here." },
                    { 79, null, 4, 1, "Dad wont mind us borrowing the car, will he? No, I ------" },
                    { 45, null, 0, 3, "Can you tell about your favorite animal?" },
                    { 51, null, 2, 1, "What can I, as your teacher, do to help you this year?" },
                    { 52, null, 2, 1, "What do you want me to know about you?" },
                    { 53, null, 2, 1, "What does a typical day look like for you" },
                    { 54, null, 2, 1, "If you could be invisible for a day, what would you do?" },
                    { 55, null, 2, 1, "What is something that makes your family special?" },
                    { 56, null, 2, 1, "What is your best quality or greatest strength?" },
                    { 57, null, 2, 1, "What do you like best about school?" },
                    { 58, null, 2, 1, "If you could change one rule that your family has, what would you change?" },
                    { 59, null, 2, 1, "What do you enjoy doing with your family?" },
                    { 60, null, 2, 1, "What is the best gift you have ever given?" },
                    { 61, null, 2, 2, "What are three things that you do every day?" },
                    { 62, null, 2, 2, "If you were a teacher, and the kids in your class would not listen to you, what would you do??" },
                    { 63, null, 2, 2, "Are you a good friend? Why do you think so?" },
                    { 64, null, 2, 2, "How would the world be different if animals could talk?" },
                    { 44, null, 0, 3, "Can you tell about your first friend?" },
                    { 65, null, 2, 2, "What is the hardest thing about being a kid?" },
                    { 43, null, 0, 3, "Can you tell about summer holidays?" },
                    { 41, null, 0, 3, "Lets talk about Great Britain. What do you know about this country?" },
                    { 6, null, 1, 1, "Look! The boys ---- running!" },
                    { 7, null, 1, 1, "\"Be\" verb in past simple" },
                    { 8, null, 1, 1, "I ---- at home yesterday" },
                    { 9, null, 1, 1, "There ---- a one apple left" },
                    { 10, null, 1, 1, "---- did she go?" },
                    { 11, null, 1, 2, "The most common animal?" },
                    { 12, null, 1, 2, "Cats lifespan?" },
                    { 13, null, 1, 2, "Dogs lifespan?" },
                    { 14, null, 1, 2, "The main ingredient of the butter?" },
                    { 15, null, 1, 2, "Wolfs are: " },
                    { 16, null, 1, 2, "Cows are: " },
                    { 17, null, 1, 2, "Humans are: " },
                    { 18, null, 1, 2, "How tall is the tallest tree?" },
                    { 19, null, 1, 2, "The largest forest in the world?" },
                    { 20, null, 1, 2, "The biggest ocean on the planet?" },
                    { 42, null, 0, 3, "Can you tell about nature?" },
                    { 66, null, 2, 2, "What superpower would you like to have and why?" },
                    { 67, null, 2, 2, "If you could make one rule that everyone in the world had to follow, what rule would you make? Why?" },
                    { 68, null, 2, 2, "Where is your favorite place in the world?" },
                    { 34, null, 3, 2, "He ---- the answers during his English test." },
                    { 35, null, 3, 2, "You need a key ---- the box." },
                    { 36, null, 3, 2, "I went to the supermarket ---- milk." },
                    { 37, null, 3, 2, "I dont know ------." },
                    { 38, null, 3, 2, "Try ------ forget." },
                    { 39, null, 3, 2, "I enjoy ------ in the office." },
                    { 40, null, 3, 2, "After ------, you should take a shower." },
                    { 46, null, 0, 3, "Describe a famous person, such as an athlete, actor, or singer. Describe their appearance. " },
                    { 47, null, 0, 3, "Describe your favorite place using as much detail as you can. " },
                    { 48, null, 0, 3, "Talk about your happiest memory. " },
                    { 49, null, 0, 3, "Describe your childhood pet." },
                    { 50, null, 0, 3, "Discuss your favorite holiday." },
                    { 76, null, 4, 1, "The taxi will be here in a couple of minutes. We ------ get ready to go." },
                    { 3, null, 1, 1, "Second verb form of \"read\"?" },
                    { 78, null, 4, 1, "The stairs ------ quite steep, so be careful how you go down." },
                    { 33, null, 3, 2, "She always listens ---- music on her phone" },
                    { 32, null, 3, 2, "Have you heard the news? Jane ---- have a baby!" },
                    { 31, null, 3, 2, "We spend a lot of time ---- the internet." },
                    { 30, null, 3, 1, "She asked if I would like ---- on a date with her." },
                    { 69, null, 2, 2, "If you could change your name, would you? If so, what name would you choose?" },
                    { 70, null, 2, 2, "What do you want to be when you grow up?" },
                    { 71, null, 2, 3, "Icebreakers" },
                    { 72, null, 2, 3, "Describing people" },
                    { 73, null, 2, 3, "Greetings & introductions" },
                    { 74, null, 2, 3, "Money" },
                    { 75, null, 2, 3, "Past tense themes" },
                    { 4, null, 1, 1, "Third verb form of \"swim\"?" },
                    { 21, null, 3, 1, "I ---- to that restaurant. The food is very good." },
                    { 23, null, 3, 1, "We knew that she ---- waiting for the the results of her English test." },
                    { 24, null, 3, 1, "You cant pass your grammar test without ----." },
                    { 25, null, 3, 1, "When the postman came, I ---- a shower." },
                    { 26, null, 3, 1, "He didnt remember that we ---- before." },
                    { 27, null, 3, 1, "Tomorrow is Saturday so she ---- work. Its her day off." },
                    { 28, null, 3, 1, "He met her at school. They have been friends ---- years." },
                    { 29, null, 3, 1, "She looks ---- a secretary." },
                    { 22, null, 3, 1, "Her parents didnt want ---- watch T.V." },
                    { 77, null, 4, 1, "The interviewer started off ------ me why I wanted the job." }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, true, 1, "London" },
                    { 209, false, 103, "has banned / has taken" },
                    { 208, true, 102, "could have been / had allowed" },
                    { 207, false, 102, "had been / would have allowed" },
                    { 206, false, 102, "would be / allowed" },
                    { 205, false, 102, "could be / could have allowed" },
                    { 204, true, 101, "very much" },
                    { 203, false, 101, "either" },
                    { 202, false, 101, "too much" },
                    { 201, false, 101, "so much as" },
                    { 400, false, 95, "The most valuable painting in the museum" },
                    { 399, false, 95, "A popular painting among the public" },
                    { 398, false, 95, "A painting that thieves favor" },
                    { 210, false, 103, "had banned / took" },
                    { 397, true, 95, "Security precautions at a museum" },
                    { 395, false, 94, "Popular musical forms in America and Europe" },
                    { 394, false, 94, "The different beats in waltzes and polkas" },
                    { 393, true, 94, "Regular beats and syncopation in music" },
                    { 392, false, 93, "A particular piece of music composed by William Krell" },
                    { 391, false, 93, "A musical form that became popular around 1900" },
                    { 390, false, 93, "One of John Philip" },
                    { 389, true, 93, "A type of traditional music with regular beats" },
                    { 388, false, 92, "Early American musical forms" },
                    { 387, true, 92, "Band concerts in America and Europe" },
                    { 386, false, 92, "Ragtime in America" },
                    { 385, false, 92, "The turn of the century" },
                    { 384, false, 91, "Czar Alexander the II" },
                    { 396, false, 94, "Mississippi Rag and Joplins Maple Leaf Rag" },
                    { 383, false, 91, "Chief Sitting Bull" },
                    { 211, true, 103, "banned / had taken" },
                    { 213, false, 104, "has been known / might be referred" },
                    { 239, false, 110, "had been settled / contained" },
                    { 238, false, 110, "has been settled / contains" },
                    { 237, false, 110, "was being settled / has contained" },
                    { 236, false, 109, "was being logged / is being destroyed" },
                    { 235, true, 109, "is being logged / will have been destroyed" },
                    { 234, false, 109, "has been logged / is destroyed" },
                    { 233, false, 109, "will be logged / would have been destroyed" },
                    { 232, true, 108, "which" },
                    { 231, false, 108, "where" },
                    { 230, false, 108, "who" },
                    { 229, false, 108, "what" },
                    { 228, false, 107, "had been directed / was not" },
                    { 212, false, 103, "bans / was taking" },
                    { 227, false, 107, "is directed / wont be" },
                    { 225, true, 107, "has been directed / is not" },
                    { 224, false, 106, "having been launched / are coming" },
                    { 223, false, 106, "being launched / will come" },
                    { 222, true, 106, "to be launched / come" },
                    { 221, false, 106, "to have been launched / have come" },
                    { 220, false, 105, "improved / had been" },
                    { 219, true, 105, "improve / might be" },
                    { 218, false, 105, "are improving / were" },
                    { 217, false, 105, "have improved / would have been" },
                    { 216, true, 104, "was known / is referred" },
                    { 215, false, 104, "had been known / had been referred" },
                    { 214, false, 104, "is known / has been" },
                    { 226, false, 107, "was being directed / wouldnt be" },
                    { 240, true, 110, "was settled / contained" },
                    { 382, true, 91, "Queen Victoria" },
                    { 380, false, 90, "The date William Cody was more widely known" },
                    { 349, false, 83, "neednt have" },
                    { 348, false, 82, "will" },
                    { 347, false, 82, "can" },
                    { 346, false, 82, "is" },
                    { 345, true, 82, "will be" },
                    { 344, false, 81, "you been crying" },
                    { 343, true, 81, "have you been crying" },
                    { 342, false, 81, "have you cried" },
                    { 341, false, 81, "did you cry" },
                    { 340, false, 80, "is belong" },
                    { 339, false, 80, "belong" },
                    { 338, false, 80, "are belonging" },
                    { 350, true, 83, "didnt need to have" },
                    { 337, true, 80, "have belonged" },
                    { 335, false, 79, "suppose" },
                    { 334, true, 79, "suppose not" },
                    { 333, false, 79, "dont suppose it" },
                    { 332, false, 78, "isnt" },
                    { 331, false, 78, "is" },
                    { 330, false, 78, "be" },
                    { 329, true, 78, "are" },
                    { 328, false, 77, "ask" },
                    { 327, false, 77, "to ask" },
                    { 326, true, 77, "by asking" },
                    { 325, false, 77, "in asking" },
                    { 324, false, 76, "better" },
                    { 336, false, 79, "not" },
                    { 381, false, 91, "William Cody" },
                    { 351, false, 83, "neednt have had" },
                    { 353, false, 84, "I was explained the problem" },
                    { 379, false, 90, "When Cody became known as Buffalo Bill" },
                    { 378, false, 90, "The year Cody started the Wild West Show" },
                    { 377, true, 90, "When the Wild West Show performed for heads of state" },
                    { 376, false, 89, "European heads of state" },
                    { 375, false, 89, "Buffalo Bills Wild West Show" },
                    { 374, false, 89, "The czar of Russia" },
                    { 373, true, 89, "American sharpshooters" },
                    { 372, false, 88, "Entering the data into the computer" },
                    { 371, false, 88, "Opening boxes of purchased books" },
                    { 370, false, 88, "Attaching the bar code" },
                    { 369, true, 88, "Logging in books" },
                    { 368, false, 87, "Logging in books" },
                    { 352, false, 83, "neednt had" },
                    { 367, false, 87, "Having a birthday" },
                    { 365, true, 87, "Unwrapping presents" },
                    { 364, false, 86, "Working in a library" },
                    { 363, false, 86, "Attaching bar codes" },
                    { 362, false, 86, "Purchasing books" },
                    { 361, true, 86, "Getting presents" },
                    { 360, false, 85, "admitted stealed" },
                    { 359, true, 85, "admitted stealing" },
                    { 358, false, 85, "admitted steal" },
                    { 357, false, 85, "admitted to steal" },
                    { 356, false, 84, "she explained me the problem" },
                    { 355, false, 84, "he explained me the problem" },
                    { 354, true, 84, "the problem was explained to me" },
                    { 366, false, 87, "Unpacking books" },
                    { 241, false, 116, "A mill" },
                    { 242, true, 116, "A club" },
                    { 243, false, 116, "A restaurant" },
                    { 455, false, 138, "is leaving" },
                    { 454, false, 138, "could have left" },
                    { 453, false, 137, "will be creating / has granted" },
                    { 452, true, 137, "created / was granted" },
                    { 451, false, 137, " had created / granted" },
                    { 450, false, 137, "has created / has been granted" },
                    { 449, true, 136, "allowed / to develop" },
                    { 448, false, 136, "were allowed / to have developed" },
                    { 447, false, 136, "have allowed / being developed" },
                    { 446, false, 136, "allow / developing" },
                    { 445, true, 135, "were given / would pick" },
                    { 444, false, 135, "would have given / had picked" },
                    { 456, false, 138, "has left" },
                    { 443, false, 135, "had been given / might pick" },
                    { 441, false, 134, "so / some" },
                    { 440, false, 134, "such / none" },
                    { 439, false, 134, "too many / any" },
                    { 438, true, 134, "enough / as much" },
                    { 437, false, 133, "the reason" },
                    { 436, false, 133, "whose" },
                    { 435, false, 133, "even if" },
                    { 434, true, 133, "why" },
                    { 433, false, 132, "that / to have overcome" },
                    { 432, false, 132, "what / to be overcoming" },
                    { 431, false, 132, "whatever / overcoming" },
                    { 430, true, 132, "anything / overcome" },
                    { 442, false, 135, "gave / could pick" },
                    { 429, false, 131, "most of / which" },
                    { 457, true, 138, "will have left" },
                    { 459, true, 139, "Every time / how" },
                    { 485, false, 144, "both" },
                    { 484, true, 144, "such as" },
                    { 483, false, 144, "just as" },
                    { 482, false, 144, "so" },
                    { 481, false, 143, "will you" },
                    { 480, false, 143, "can you" },
                    { 479, true, 143, "are you" },
                    { 478, false, 143, " do I" },
                    { 477, false, 142, "more / than" },
                    { 476, false, 142, "as / as" },
                    { 475, false, 142, "too / such" },
                    { 474, true, 142, "so / that" },
                    { 458, false, 139, "During / whether" },
                    { 473, true, 141, "to vary / leading" },
                    { 471, false, 141, "varying / led" },
                    { 470, false, 141, "to be varying / to lead" },
                    { 469, false, 141, "so" },
                    { 468, false, 141, "only" },
                    { 467, true, 141, "nor" },
                    { 466, false, 141, "as" },
                    { 465, true, 140, "yet / another" },
                    { 464, false, 140, "already / every other" },
                    { 463, false, 140, "still / each" },
                    { 462, false, 140, "so far / every" },
                    { 461, false, 139, "Until / if" },
                    { 460, false, 139, "Whenever / what" },
                    { 472, false, 141, "to have varied / being led" },
                    { 428, true, 131, "some / that" },
                    { 427, false, 131, "such / as" },
                    { 426, false, 131, " a few / by which" },
                    { 269, false, 123, "Violin and saxophone" },
                    { 268, false, 122, "Museums" },
                    { 267, false, 122, "Houses and schools" },
                    { 266, false, 122, "Parks and green spaces" },
                    { 265, true, 122, "Coffee shops, clubs and restaurants" },
                    { 264, false, 121, "Moscow" },
                    { 263, false, 121, "Canada" },
                    { 262, true, 121, "London" },
                    { 261, false, 121, "Manchester" },
                    { 260, false, 120, "Russian people" },
                    { 259, false, 120, "Canadian people" },
                    { 258, false, 120, "London people" },
                    { 270, true, 123, "Guitar, piano and electronic instruments" },
                    { 257, true, 120, "Manchester people" },
                    { 255, false, 119, "She doesnt play any instruments." },
                    { 254, true, 119, "Guitar, piano and electronic instruments" },
                    { 253, false, 119, "Violin and saxophone" },
                    { 252, false, 118, "Museums" },
                    { 251, false, 118, "Houses and schools" },
                    { 250, false, 118, "Parks and green spaces" },
                    { 249, true, 118, "Coffee shops, clubs and restaurants" },
                    { 248, false, 117, "A pub" },
                    { 247, false, 117, "A restaurant" },
                    { 246, true, 117, "A club" },
                    { 245, false, 117, "A mill" },
                    { 244, false, 116, "A pub" },
                    { 256, false, 119, "She  plays the flute." },
                    { 271, false, 123, "She doesnt play any instruments." },
                    { 272, false, 123, "She plays the flute." },
                    { 273, true, 124, "Manchester people" },
                    { 425, true, 130, "While" },
                    { 424, false, 130, "In addition to" },
                    { 423, false, 130, "Despite" },
                    { 422, false, 130, "What" },
                    { 421, false, 129, "before" },
                    { 420, false, 129, "even when" },
                    { 419, true, 129, "if" },
                    { 418, false, 129, "unless" },
                    { 417, false, 128, "may have knocked" },
                    { 416, false, 128, "will have to knock" },
                    { 415, true, 128, "were able to knock" },
                    { 414, false, 128, "would have knocked" },
                    { 413, true, 127, "had been lying / was spotted" },
                    { 412, false, 127, "will have lain / had been spotted" },
                    { 411, false, 127, "has lain / will be spotted" },
                    { 410, false, 127, "has been lying / is spotting" },
                    { 409, true, 126, "originated / began" },
                    { 408, false, 126, "could have originated / have begun" },
                    { 407, false, 126, "had originated / began" },
                    { 406, false, 126, "have originated / had begun" },
                    { 280, false, 125, "Moscow" },
                    { 279, false, 125, "Canada" },
                    { 278, true, 125, "London" },
                    { 277, false, 125, "Manchester" },
                    { 276, false, 124, "Russian people" },
                    { 275, false, 124, "Canadian people" },
                    { 274, false, 124, "London people" },
                    { 322, false, 76, "would better" },
                    { 321, true, 76, "had better" },
                    { 323, false, 76, "should better" },
                    { 159, false, 40, "doing swim" },
                    { 168, false, 52, "Location" },
                    { 167, false, 52, "Salary" },
                    { 166, true, 52, "Name" },
                    { 165, false, 52, "Job" },
                    { 164, false, 51, "Game" },
                    { 163, false, 51, "Money" },
                    { 162, false, 51, "Brain" },
                    { 161, true, 51, "Teach" },
                    { 80, false, 20, "The Arctic Ocean" },
                    { 79, false, 20, "The Indian Ocean" },
                    { 78, false, 20, "The Atlantic Ocean" },
                    { 77, true, 20, "The Pacific Ocean" },
                    { 169, true, 53, "Funny" },
                    { 76, false, 19, "The Araucaria Forest" },
                    { 74, false, 19, "Yakushima Forest" },
                    { 73, true, 19, "The Amazon" },
                    { 72, false, 18, "90 meters" },
                    { 71, false, 18, "100 meters" },
                    { 70, false, 18, "110 meters" },
                    { 69, true, 18, "115.7 meters" },
                    { 68, false, 17, "Vegeterian" },
                    { 67, true, 17, "Omnivorous" },
                    { 66, false, 17, "Herbivorous" },
                    { 65, false, 17, "Carnivorous" },
                    { 64, false, 16, "Vegeterian" },
                    { 63, false, 16, "Omnivorous" },
                    { 75, false, 19, "Waipoua Forest" },
                    { 62, true, 16, "Herbivorous" },
                    { 170, false, 53, "Normal" },
                    { 172, false, 53, "Bad" },
                    { 160, false, 40, "to swim" },
                    { 197, true, 60, "Buy a new car" },
                    { 196, true, 59, "Snatch" },
                    { 195, false, 59, "Make money" },
                    { 194, false, 59, "Relax" },
                    { 193, false, 59, "Hunt" },
                    { 192, false, 58, "Money" },
                    { 191, false, 58, "House" },
                    { 190, false, 58, "Future" },
                    { 189, true, 58, "Location" },
                    { 188, false, 57, "Relax time" },
                    { 187, true, 57, "Lessons" },
                    { 171, false, 53, "Ugly" },
                    { 186, false, 57, "Objects" },
                    { 184, false, 56, "Hardwork" },
                    { 183, false, 56, "Lidership" },
                    { 182, false, 56, "Opacity" },
                    { 181, true, 56, "Brain" },
                    { 180, false, 55, "Education" },
                    { 179, false, 55, "Level" },
                    { 178, true, 55, "Money" },
                    { 177, false, 55, "Job" },
                    { 176, false, 54, "Play" },
                    { 175, true, 54, "Relax" },
                    { 174, false, 54, "Snatch" },
                    { 173, false, 54, "Drink" },
                    { 185, false, 57, "Subjects" },
                    { 61, false, 16, "Carnivorous" },
                    { 60, false, 15, "Vegeterian" },
                    { 59, false, 15, "Omnivorous" },
                    { 27, true, 7, "was/were" },
                    { 26, false, 7, "be" },
                    { 25, false, 7, "will be" },
                    { 24, false, 6, "is" },
                    { 23, false, 6, "they" },
                    { 22, false, 6, "am" },
                    { 21, true, 6, "are" },
                    { 20, false, 5, "he" },
                    { 19, false, 5, "am" },
                    { 18, true, 5, "is" },
                    { 17, false, 5, "are" },
                    { 16, false, 4, "Slim" },
                    { 28, false, 7, "has" },
                    { 15, true, 4, "Swum" },
                    { 13, false, 4, "Swim" },
                    { 12, false, 3, "Road" },
                    { 11, false, 3, "Red" },
                    { 10, false, 3, "Rat" },
                    { 9, true, 3, "Read" },
                    { 8, false, 2, "10" },
                    { 7, false, 2, "16" },
                    { 6, true, 2, "12" },
                    { 5, false, 2, "14" },
                    { 4, false, 1, "Minsk" },
                    { 3, false, 1, "Moscow" },
                    { 2, false, 1, "Paris" },
                    { 14, false, 4, "Swam" },
                    { 29, true, 8, "was" },
                    { 30, false, 8, "will be" },
                    { 31, false, 8, "is" },
                    { 58, false, 15, "Herbivorous" },
                    { 57, true, 15, "Carnivorous" },
                    { 56, false, 14, "Oil" },
                    { 55, false, 14, "Salt" },
                    { 54, false, 14, "Sugar" },
                    { 53, true, 14, "Milk" },
                    { 52, false, 13, "1 to 2 years" },
                    { 51, false, 13, "2 to 16 years" },
                    { 50, false, 13, "5 to 10 years" },
                    { 49, true, 13, "10 to 13 years" },
                    { 48, false, 12, "5 to 10 years" },
                    { 47, false, 12, "16 to 24 years" },
                    { 46, false, 12, "1 to 4 years" },
                    { 45, true, 12, "2 to 16 years" },
                    { 44, false, 11, "Goat" },
                    { 43, false, 11, "Cow" },
                    { 42, false, 11, "Dog" },
                    { 41, true, 11, "Cat" },
                    { 40, false, 10, "How many" },
                    { 39, false, 10, "Which" },
                    { 38, false, 10, "Who" },
                    { 37, true, 10, "Where" },
                    { 36, true, 9, "is" },
                    { 35, false, 9, "are" },
                    { 34, false, 9, "am" },
                    { 33, false, 9, "will be" },
                    { 32, false, 8, "were" },
                    { 199, false, 60, "Make money" },
                    { 200, false, 60, "Run to Feature" },
                    { 198, false, 60, "Build a house" },
                    { 282, false, 61, "Dog" },
                    { 128, true, 32, "is going to" },
                    { 127, false, 32, "will" },
                    { 126, false, 32, "would" },
                    { 125, false, 32, "should" },
                    { 124, false, 31, "for" },
                    { 123, false, 31, "by" },
                    { 122, false, 31, "to" },
                    { 121, true, 31, "on" },
                    { 120, false, 30, "to went" },
                    { 119, false, 30, "go" },
                    { 118, false, 30, "going" },
                    { 117, true, 30, "to go" },
                    { 129, false, 33, "by" },
                    { 116, true, 29, "like" },
                    { 114, false, 29, "the same like" },
                    { 113, false, 29, "the same as" },
                    { 112, false, 28, "many" },
                    { 111, false, 28, "since" },
                    { 110, true, 28, "for" },
                    { 109, false, 28, "until" },
                    { 108, false, 27, "hasnt" },
                    { 107, true, 27, "doesnt have to" },
                    { 106, false, 27, "mustnt" },
                    { 105, false, 27, "wouldnt" },
                    { 104, true, 26, "had met" },
                    { 281, true, 61, "Cat" },
                    { 115, false, 29, "as" },
                    { 102, false, 26, "met" },
                    { 130, false, 33, "for" },
                    { 132, false, 33, "the" },
                    { 158, true, 40, "swimming" },
                    { 157, false, 40, "swim" },
                    { 156, true, 39, "working" },
                    { 155, false, 39, "to working" },
                    { 154, false, 39, "to work" },
                    { 153, false, 39, "to working" },
                    { 152, false, 38, "arent" },
                    { 151, false, 38, "to dont" },
                    { 150, false, 38, "dont to" },
                    { 149, true, 38, "not to" },
                    { 148, false, 37, "what are they wanting" },
                    { 147, false, 37, "what do they want" },
                    { 131, true, 33, "to" },
                    { 146, true, 37, "what they want" },
                    { 144, true, 36, "to buy" },
                    { 143, false, 36, "for to buy" },
                    { 142, false, 36, "for buying" },
                    { 141, false, 36, "to buying" },
                    { 140, false, 35, "for oppening" },
                    { 139, false, 35, "for to open" },
                    { 138, true, 35, "to open" },
                    { 137, false, 35, "for open" },
                    { 136, false, 34, "always is forgetting" },
                    { 135, false, 34, "always forgetting" },
                    { 134, false, 34, "forgets always" },
                    { 133, true, 34, "always forgets" },
                    { 145, false, 37, "they do want" },
                    { 101, false, 26, "were meeting" },
                    { 103, false, 26, "meet" },
                    { 99, false, 25, "have been having" },
                    { 100, false, 25, "had been having" },
                    { 307, true, 67, "Omnivorous" },
                    { 306, false, 67, "Herbivorous" },
                    { 305, false, 67, "Carnivorous" },
                    { 304, false, 66, "Vegeterian" },
                    { 303, false, 66, "Omnivorous" },
                    { 302, true, 66, "Herbivorous" },
                    { 301, false, 66, "Carnivorous" },
                    { 300, false, 65, "Vegeterian" },
                    { 299, false, 65, "Omnivorous" },
                    { 298, false, 65, "Herbivorous" },
                    { 297, true, 65, "Carnivorous" },
                    { 309, true, 68, "115.7 meters" },
                    { 296, false, 64, "Oil" },
                    { 294, false, 64, "Sugar" },
                    { 293, true, 64, "Milk" },
                    { 292, false, 63, "1-2 years" },
                    { 291, false, 63, "2-16 years" },
                    { 290, false, 63, "5-10 years" },
                    { 289, true, 63, "10-13 years" },
                    { 288, false, 62, "5-10 years" },
                    { 287, false, 62, "16-24 years" },
                    { 286, false, 62, "1-4 years" },
                    { 285, true, 62, "2-16 years" },
                    { 284, false, 61, "Goat" },
                    { 283, false, 61, "Cow" },
                    { 295, false, 64, "Salt" },
                    { 310, false, 68, "110 meters" },
                    { 308, false, 67, "Vegeterian" },
                    { 312, false, 68, "90 meters" },
                    { 98, false, 25, "had" },
                    { 97, true, 25, "was having" },
                    { 96, false, 24, "are studying" },
                    { 95, false, 24, "to study" },
                    { 94, true, 24, "studying" },
                    { 93, false, 24, "you study" },
                    { 92, true, 23, "was " },
                    { 91, false, 23, "had been" },
                    { 90, false, 23, "would" },
                    { 89, false, 23, "is" },
                    { 311, false, 68, "100 meters" },
                    { 87, false, 22, "that she watch" },
                    { 86, false, 22, "her watch" },
                    { 88, false, 22, "so she watch" },
                    { 84, false, 21, "has often been" },
                    { 313, true, 69, "The Amazon" },
                    { 314, false, 69, "Yakushima Forest" },
                    { 85, true, 22, "her to watch" },
                    { 316, false, 69, "The Araucaria Forest" },
                    { 317, true, 70, "The Pacific Ocean" },
                    { 315, false, 69, "Waipoua Forest" },
                    { 319, false, 70, "The Indian Ocean" },
                    { 320, false, 70, "The Arctic Ocean" },
                    { 81, false, 21, "often have been" },
                    { 82, false, 21, "have been often" },
                    { 83, true, 21, "have often been" },
                    { 318, false, 70, "The Atlantic Ocean" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { 1, 1, "UserRole" },
                    { 2, 2, "UserRole" },
                    { 3, 3, "UserRole" }
                });

            migrationBuilder.InsertData(
                table: "PassedTests",
                columns: new[] { "Id", "AssessmentId", "AssignTestId", "CheckerId", "LevelType", "PassedTestDate", "Status", "UserId", "UserTestId" },
                values: new object[,]
                {
                    { 2, 2, null, 3, 3, new DateTime(2021, 8, 17, 11, 13, 32, 102, DateTimeKind.Local).AddTicks(4413), 3, 2, null },
                    { 1, 1, null, 2, 5, new DateTime(2021, 8, 17, 14, 13, 32, 100, DateTimeKind.Local).AddTicks(7973), 3, 1, null },
                    { 3, 3, null, 2, 4, new DateTime(2021, 8, 16, 14, 13, 32, 102, DateTimeKind.Local).AddTicks(4531), 3, 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserAnswers",
                columns: new[] { "Id", "Answer", "Assessment", "PassedTestId", "QuestionId", "ReportId" },
                values: new object[,]
                {
                    { 11, "very much", 1, 1, 101, null },
                    { 30, "Guitar, piano and electronic instruments", 1, 1, 123, null },
                    { 29, "Coffee shops, clubs and restaurants", 1, 1, 122, null },
                    { 28, "London", 1, 1, 121, null },
                    { 27, "Manchester people", 1, 1, 120, null },
                    { 26, "Violin and saxophone", 0, 1, 119, null },
                    { 25, "Coffee shops, clubs and restaurants", 1, 1, 118, null },
                    { 24, "A club", 1, 1, 117, null },
                    { 23, "A club", 1, 1, 116, null },
                    { 22, "audiourl", 0, 1, 112, null },
                    { 21, "krjgherg hesrgherghsrtjughsrjg seorgp4weurdfkjvnsdfgiu yeorghsdflmvns rgoiwryhg seorgiergo hroghrogih soeitgyero gihsrogj heroht osr", 0, 1, 111, null },
                    { 20, "was settled / contained", 1, 1, 110, null },
                    { 19, "is being logged / will have been destroyed", 1, 1, 109, null },
                    { 18, "which", 1, 1, 108, null },
                    { 17, "is directed / wont be", 0, 1, 107, null },
                    { 16, "to be launched / come", 1, 1, 106, null },
                    { 15, "improve / might be", 1, 1, 105, null },
                    { 14, "has been known / might be referred", 0, 1, 104, null },
                    { 13, "has banned / has taken", 0, 1, 103, null },
                    { 12, "could have been / had allowed", 1, 1, 102, null },
                    { 31, "Manchester people", 1, 1, 124, null },
                    { 32, "London", 1, 1, 125, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssignTests_AssignerId",
                table: "AssignTests",
                column: "AssignerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignTests_UserId",
                table: "AssignTests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PassedTests_AssessmentId",
                table: "PassedTests",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PassedTests_AssignTestId",
                table: "PassedTests",
                column: "AssignTestId");

            migrationBuilder.CreateIndex(
                name: "IX_PassedTests_CheckerId",
                table: "PassedTests",
                column: "CheckerId");

            migrationBuilder.CreateIndex(
                name: "IX_PassedTests_UserId",
                table: "PassedTests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PassedTests_UserTestId",
                table: "PassedTests",
                column: "UserTestId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUserTest_UserTestId",
                table: "QuestionUserTest",
                column: "UserTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_QuestionId",
                table: "Reports",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_PassedTestId",
                table: "UserAnswers",
                column: "PassedTestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_QuestionId",
                table: "UserAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_ReportId",
                table: "UserAnswers",
                column: "ReportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop procedure archiveexpiredassigntest(TIMESPAN)");
            migrationBuilder.Sql("drop procedure archiveexpiredassignedtest()");
            migrationBuilder.Sql("drop procedure archivepassedassignedtest()");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "QuestionUserTest");

            migrationBuilder.DropTable(
                name: "UserAnswers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PassedTests");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "AssignTests");

            migrationBuilder.DropTable(
                name: "UserTests");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
