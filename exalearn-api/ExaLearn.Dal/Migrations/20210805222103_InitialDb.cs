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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
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
                    RoleId = table.Column<int>(type: "integer", nullable: false)
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
                name: "PassedTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CheckerId = table.Column<int>(type: "integer", nullable: true),
                    AssignTestId = table.Column<int>(type: "integer", nullable: true),
                    LevelType = table.Column<int>(type: "integer", nullable: false),
                    Assessment = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_PassedTests_AssignTests_AssignTestId",
                        column: x => x.AssignTestId,
                        principalTable: "AssignTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PassedTestId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Action = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Histories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Histories_PassedTests_PassedTestId",
                        column: x => x.PassedTestId,
                        principalTable: "PassedTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PassedTestId = table.Column<int>(type: "integer", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    ReportId = table.Column<int>(type: "integer", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: true),
                    FileUrl = table.Column<string>(type: "text", nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FileUrl", "LevelType", "QuestionType", "Text" },
                values: new object[,]
                {
                    { 1, null, 1, 1, "Capital of the England?" },
                    { 91, null, 4, 2, "In addition to Annie Oakley, which other famous person traveled with Buffalo Bill?" },
                    { 90, null, 4, 2, "What is the woman referring to when she states, That was in 1883?" },
                    { 89, null, 4, 2, "What is the talk mainly about?" },
                    { 88, null, 4, 2, "Which duty does the man like the least?" },
                    { 87, null, 4, 2, "What is the woman referring to when she states, that sounds like fun?" },
                    { 86, null, 4, 2, "What are the people discussing?" },
                    { 85, null, 4, 1, "Steven ------ the wallet." },
                    { 84, null, 4, 1, "When I asked what was wrong, ------" },
                    { 83, null, 4, 1, "I ------ an interview because Id worked there before." },
                    { 82, null, 4, 1, "I dont know when Helen ------ back." },
                    { 81, null, 4, 1, "Your eyes are red ------?" },
                    { 80, null, 4, 1, "We ------ to the tennis club since we moved here." },
                    { 79, null, 4, 1, "Dad wont mind us borrowing the car, will he? No, I ------" },
                    { 78, null, 4, 1, "The stairs ------ quite steep, so be careful how you go down." },
                    { 77, null, 4, 1, "The interviewer started off ------ me why I wanted the job." },
                    { 76, null, 4, 1, "The taxi will be here in a couple of minutes. We ------ get ready to go." },
                    { 50, null, 0, 3, "Discuss your favorite holiday." },
                    { 49, null, 0, 3, "Describe your childhood pet." },
                    { 48, null, 0, 3, "Talk about your happiest memory. " },
                    { 47, null, 0, 3, "Describe your favorite place using as much detail as you can. " },
                    { 46, null, 0, 3, "Describe a famous person, such as an athlete, actor, or singer. Describe their appearance. " },
                    { 40, null, 3, 2, "After ------, you should take a shower." },
                    { 39, null, 3, 2, "I enjoy ------ in the office." },
                    { 38, null, 3, 2, "Try ------ forget." },
                    { 37, null, 3, 2, "I dont know ------." },
                    { 36, null, 3, 2, "I went to the supermarket ---- milk." },
                    { 35, null, 3, 2, "You need a key ---- the box." },
                    { 92, null, 4, 2, "What does the speaker mainly discuss?" },
                    { 93, null, 4, 2, "According to the professor, what is ragtime?" },
                    { 94, null, 4, 2, "What does the professor contrast in his lecture?" },
                    { 95, null, 4, 2, "What are the people discussing?" },
                    { 123, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What does Ella play2?" },
                    { 122, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "The Northern Quarter had mills in the industrial era, but what is there now2?" },
                    { 121, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "Where was Ella born?" },
                    { 120, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "According to Ella, who spends more time in the studio?" },
                    { 119, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What does Ella play?" },
                    { 118, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "The Northern Quarter had mills in the industrial era, but what is there now?" },
                    { 117, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What was the Hacienda2?" },
                    { 116, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "What was the Hacienda?" },
                    { 115, null, 5, 3, "Parenting" },
                    { 114, null, 5, 3, "Childhood trends" },
                    { 113, null, 5, 3, "Rich world, poor world." },
                    { 112, null, 5, 3, "Electric cars" },
                    { 111, null, 5, 3, "Coronavirus" },
                    { 34, null, 3, 2, "He ---- the answers during his English test." },
                    { 110, null, 5, 1, "The continuing controversy ------ in 1924 by P. Hubble, who found that the great spiral nebula in Andromeda ------ Cepheld variables." },
                    { 108, null, 5, 1, "Galileo originated the method of controlled experiment ------ now forms the basis of scientific investigation." },
                    { 107, null, 5, 1, "Much health education in recent years ------ towards the view that heavy drinker ------  subject for amusement but for practical help." },
                    { 106, null, 5, 1, "It is not unusual for advertising campaigns ------ even before the new products ------ onto the market." },
                    { 105, null, 5, 1, "Sometimes people select certain foods that they believe ------ their physical appearance and avoid those they believe ------ detrimental." },
                    { 104, null, 5, 1, "Physics, as it ------ at the end of the nineteenth century, ------ to as classical physics." },
                    { 103, null, 5, 1, "Early in 1940, when Europe was already at war, Hitler ------  the sale of uranium from the Czech mines he ------ over." },
                    { 102, null, 5, 1, "Julius Caesar ------ a great historian if the making of history ------ him the time and the inclination to write it." },
                    { 101, null, 5, 1, "Until the eighteenth century comparative linguistic studies did not progress ------ beyond the stage where ancient Greek and Roman grammarians had left them." },
                    { 405, null, 4, 3, "Meaning of life" },
                    { 404, null, 4, 3, "tell us about Platos cave" },
                    { 403, null, 4, 3, "Why we live on this earth?" },
                    { 402, null, 4, 3, "Life after death" },
                    { 401, null, 4, 3, "What do you think about happiness" },
                    { 109, null, 5, 1, "Unfortunately, the worlds forest ------ at such a rate that the remaining tropical rainforests ------ by the middle of the century." },
                    { 124, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "According to Ella, who spends more time in the studio2?" },
                    { 33, null, 3, 2, "She always listens ---- music on her phone" },
                    { 31, null, 3, 2, "We spend a lot of time ---- the internet." },
                    { 53, null, 2, 1, "What does a typical day look like for you" },
                    { 52, null, 2, 1, "What do you want me to know about you?" },
                    { 51, null, 2, 1, "What can I, as your teacher, do to help you this year?" },
                    { 45, null, 0, 3, "Can you tell about your favorite animal?" },
                    { 44, null, 0, 3, "Can you tell about your first friend?" },
                    { 43, null, 0, 3, "Can you tell about summer holidays?" },
                    { 42, null, 0, 3, "Can you tell about nature?" },
                    { 41, null, 0, 3, "Lets talk about Great Britain. What do you know about this country?" },
                    { 20, null, 1, 2, "The biggest ocean on the planet?" },
                    { 19, null, 1, 2, "The largest forest in the world?" },
                    { 18, null, 1, 2, "How tall is the tallest tree?" },
                    { 17, null, 1, 2, "Humans are: " },
                    { 16, null, 1, 2, "Cows are: " },
                    { 15, null, 1, 2, "Wolfs are: " },
                    { 14, null, 1, 2, "The main ingredient of the butter?" },
                    { 13, null, 1, 2, "Dogs lifespan?" },
                    { 12, null, 1, 2, "Cats lifespan?" },
                    { 11, null, 1, 2, "The most common animal?" },
                    { 10, null, 1, 1, "---- did she go?" },
                    { 9, null, 1, 1, "There ---- a one apple left" },
                    { 8, null, 1, 1, "I ---- at home yesterday" },
                    { 7, null, 1, 1, "\"Be\" verb in past simple" },
                    { 6, null, 1, 1, "Look! The boys ---- running!" },
                    { 5, null, 1, 1, "Joe ---- a good driver" },
                    { 4, null, 1, 1, "Third verb form of \"swim\"?" },
                    { 3, null, 1, 1, "Second verb form of \"read\"?" },
                    { 2, null, 1, 1, "How many major verb tenses are in english?" },
                    { 54, null, 2, 1, "If you could be invisible for a day, what would you do?" },
                    { 55, null, 2, 1, "What is something that makes your family special?" },
                    { 56, null, 2, 1, "What is your best quality or greatest strength?" },
                    { 57, null, 2, 1, "What do you like best about school?" },
                    { 30, null, 3, 1, "She asked if I would like ---- on a date with her." },
                    { 29, null, 3, 1, "She looks ---- a secretary." },
                    { 28, null, 3, 1, "He met her at school. They have been friends ---- years." },
                    { 27, null, 3, 1, "Tomorrow is Saturday so she ---- work. Its her day off." },
                    { 26, null, 3, 1, "He didnt remember that we ---- before." },
                    { 25, null, 3, 1, "When the postman came, I ---- a shower." },
                    { 24, null, 3, 1, "You cant pass your grammar test without ----." },
                    { 23, null, 3, 1, "We knew that she ---- waiting for the the results of her English test." },
                    { 22, null, 3, 1, "Her parents didnt want ---- watch T.V." },
                    { 21, null, 3, 1, "I ---- to that restaurant. The food is very good." },
                    { 75, null, 2, 3, "Past tense themes" },
                    { 74, null, 2, 3, "Money" },
                    { 73, null, 2, 3, "Greetings & introductions" },
                    { 32, null, 3, 2, "Have you heard the news? Jane ---- have a baby!" },
                    { 72, null, 2, 3, "Describing people" },
                    { 70, null, 2, 2, "What do you want to be when you grow up?" },
                    { 69, null, 2, 2, "If you could change your name, would you? If so, what name would you choose?" },
                    { 68, null, 2, 2, "Where is your favorite place in the world?" },
                    { 67, null, 2, 2, "If you could make one rule that everyone in the world had to follow, what rule would you make? Why?" },
                    { 66, null, 2, 2, "What superpower would you like to have and why?" },
                    { 65, null, 2, 2, "What is the hardest thing about being a kid?" },
                    { 64, null, 2, 2, "How would the world be different if animals could talk?" },
                    { 63, null, 2, 2, "Are you a good friend? Why do you think so?" },
                    { 62, null, 2, 2, "If you were a teacher, and the kids in your class would not listen to you, what would you do??" },
                    { 61, null, 2, 2, "What are three things that you do every day?" },
                    { 60, null, 2, 1, "What is the best gift you have ever given?" },
                    { 59, null, 2, 1, "What do you enjoy doing with your family?" },
                    { 58, null, 2, 1, "If you could change one rule that your family has, what would you change?" },
                    { 71, null, 2, 3, "Icebreakers" },
                    { 125, "https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3", 5, 2, "Where was Ella born2?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, true, 1, "London" },
                    { 353, false, 84, "I was explained the problem" },
                    { 352, false, 83, "neednt had" },
                    { 351, false, 83, "neednt have had" },
                    { 350, true, 83, "didnt need to have" },
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
                    { 337, true, 80, "have belonged" },
                    { 336, false, 79, "not" },
                    { 335, false, 79, "suppose" },
                    { 334, true, 79, "suppose not" },
                    { 333, false, 79, "dont suppose it" },
                    { 354, true, 84, "the problem was explained to me" },
                    { 332, false, 78, "isnt" },
                    { 355, false, 84, "he explained me the problem" },
                    { 357, false, 85, "admitted to steal" },
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
                    { 367, false, 87, "Having a birthday" },
                    { 366, false, 87, "Unpacking books" },
                    { 365, true, 87, "Unwrapping presents" },
                    { 364, false, 86, "Working in a library" },
                    { 363, false, 86, "Attaching bar codes" },
                    { 362, false, 86, "Purchasing books" },
                    { 361, true, 86, "Getting presents" },
                    { 360, false, 85, "admitted stealed" },
                    { 359, true, 85, "admitted stealing" },
                    { 358, false, 85, "admitted steal" },
                    { 356, false, 84, "she explained me the problem" },
                    { 379, false, 90, "When Cody became known as Buffalo Bill" },
                    { 331, false, 78, "is" },
                    { 329, true, 78, "are" },
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
                    { 132, false, 33, "the" },
                    { 131, true, 33, "to" },
                    { 130, false, 33, "for" },
                    { 129, false, 33, "by" },
                    { 128, true, 32, "is going to" },
                    { 127, false, 32, "will" },
                    { 126, false, 32, "would" },
                    { 125, false, 32, "should" },
                    { 124, false, 31, "for" },
                    { 123, false, 31, "by" },
                    { 144, true, 36, "to buy" },
                    { 330, false, 78, "be" },
                    { 145, false, 37, "they do want" },
                    { 147, false, 37, "what do they want" },
                    { 328, false, 77, "ask" },
                    { 327, false, 77, "to ask" },
                    { 326, true, 77, "by asking" },
                    { 325, false, 77, "in asking" },
                    { 324, false, 76, "better" },
                    { 323, false, 76, "should better" },
                    { 322, false, 76, "would better" },
                    { 321, true, 76, "had better" },
                    { 160, false, 40, "to swim" },
                    { 159, false, 40, "doing swim" },
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
                    { 146, true, 37, "what they want" },
                    { 122, false, 31, "to" },
                    { 380, false, 90, "The date William Cody was more widely known" },
                    { 382, true, 91, "Queen Victoria" },
                    { 268, false, 118, "Museums" },
                    { 252, false, 118, "Museums" },
                    { 251, false, 118, "Houses and schools" },
                    { 250, false, 118, "Parks and green spaces" },
                    { 249, true, 118, "Coffee shops, clubs and restaurants" },
                    { 248, false, 117, "A pub" },
                    { 247, false, 117, "A restaurant" },
                    { 246, true, 117, "A club" },
                    { 245, false, 117, "A mill" },
                    { 244, false, 116, "A pub" },
                    { 243, false, 116, "A restaurant" },
                    { 242, true, 116, "A club" },
                    { 241, false, 116, "A mill" },
                    { 240, true, 110, "was settled / contained" },
                    { 239, false, 110, "had been settled / contained" },
                    { 238, false, 110, "has been settled / contains" },
                    { 237, false, 110, "was being settled / has contained" },
                    { 236, false, 109, "was being logged / is being destroyed" },
                    { 235, true, 109, "is being logged / will have been destroyed" },
                    { 234, false, 109, "has been logged / is destroyed" },
                    { 233, false, 109, "will be logged / would have been destroyed" },
                    { 253, false, 119, "Violin and saxophone" },
                    { 232, true, 108, "which" },
                    { 254, true, 119, "Guitar, piano and electronic instruments" },
                    { 256, false, 119, "She  plays the flute." },
                    { 278, true, 125, "London" },
                    { 277, false, 125, "Manchester" },
                    { 276, false, 124, "Russian people" },
                    { 275, false, 124, "Canadian people" },
                    { 274, false, 124, "London people" },
                    { 273, true, 124, "Manchester people" },
                    { 272, false, 123, "She plays the flute." },
                    { 271, false, 123, "She doesnt play any instruments." },
                    { 270, true, 123, "Guitar, piano and electronic instruments" },
                    { 269, false, 123, "Violin and saxophone" },
                    { 267, false, 122, "Houses and schools" },
                    { 266, false, 122, "Parks and green spaces" },
                    { 265, true, 122, "Coffee shops, clubs and restaurants" },
                    { 264, false, 120, "Moscow" },
                    { 263, false, 120, "Canada" },
                    { 262, true, 120, "London" },
                    { 261, false, 120, "Manchester" },
                    { 260, false, 120, "Russian people" },
                    { 259, false, 120, "Canadian people" },
                    { 258, false, 120, "London people" },
                    { 257, true, 120, "Manchester people" },
                    { 255, false, 119, "She doesnt play any instruments." },
                    { 381, false, 91, "William Cody" },
                    { 231, false, 108, "where" },
                    { 229, false, 108, "what" },
                    { 203, false, 101, "either" },
                    { 202, false, 101, "too much" },
                    { 201, false, 101, "so much as" },
                    { 400, false, 95, "The most valuable painting in the museum" },
                    { 399, false, 95, "A popular painting among the public" },
                    { 398, false, 95, "A painting that thieves favor" },
                    { 397, true, 95, "Security precautions at a museum" },
                    { 396, false, 94, "Mississippi Rag and Joplins Maple Leaf Rag" },
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
                    { 383, false, 91, "Chief Sitting Bull" },
                    { 204, true, 101, "very much" },
                    { 230, false, 108, "who" },
                    { 205, false, 102, "could be / could have allowed" },
                    { 207, false, 102, "had been / would have allowed" },
                    { 228, false, 107, "had been directed / was not" },
                    { 227, false, 107, "is directed / wont be" },
                    { 226, false, 107, "was being directed / wouldnt be" },
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
                    { 213, false, 104, "has been known / might be referred" },
                    { 212, false, 103, "bans / was taking" },
                    { 211, true, 103, "banned / had taken" },
                    { 210, false, 103, "had banned / took" },
                    { 209, false, 103, "has banned / has taken" },
                    { 208, true, 102, "could have been / had allowed" },
                    { 206, false, 102, "would be / allowed" },
                    { 121, true, 31, "on" },
                    { 120, false, 30, "to went" },
                    { 119, false, 30, "go" },
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
                    { 62, true, 16, "Herbivorous" },
                    { 61, false, 16, "Carnivorous" },
                    { 60, false, 15, "Vegeterian" },
                    { 59, false, 15, "Omnivorous" },
                    { 58, false, 15, "Herbivorous" },
                    { 57, true, 15, "Carnivorous" },
                    { 56, false, 14, "Oil" },
                    { 55, false, 14, "Salt" },
                    { 54, false, 14, "Sugar" },
                    { 53, true, 14, "Milk" },
                    { 52, false, 13, "1 to 2 years" },
                    { 73, true, 19, "The Amazon" },
                    { 51, false, 13, "2 to 16 years" },
                    { 74, false, 19, "Yakushima Forest" },
                    { 76, false, 19, "The Araucaria Forest" },
                    { 177, false, 55, "Job" },
                    { 176, false, 54, "Play" },
                    { 175, true, 54, "Relax" },
                    { 174, false, 54, "Snatch" },
                    { 173, false, 54, "Drink" },
                    { 172, false, 53, "Bad" },
                    { 171, false, 53, "Ugly" },
                    { 170, false, 53, "Normal" },
                    { 169, true, 53, "Funny" },
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
                    { 75, false, 19, "Waipoua Forest" },
                    { 178, true, 55, "Money" },
                    { 50, false, 13, "5 to 10 years" },
                    { 48, false, 12, "5 to 10 years" },
                    { 22, false, 6, "am" },
                    { 21, true, 6, "are" },
                    { 20, false, 5, "he" },
                    { 19, false, 5, "am" },
                    { 18, true, 5, "is" },
                    { 17, false, 5, "are" },
                    { 16, false, 4, "Slim" },
                    { 15, true, 4, "Swum" },
                    { 14, false, 4, "Swam" },
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
                    { 23, false, 6, "they" },
                    { 49, true, 13, "10 to 13 years" },
                    { 24, false, 6, "is" },
                    { 26, false, 7, "be" },
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
                    { 31, false, 8, "is" },
                    { 30, false, 8, "will be" },
                    { 29, true, 8, "was" },
                    { 28, false, 7, "has" },
                    { 27, true, 7, "was/were" },
                    { 25, false, 7, "will be" },
                    { 179, false, 55, "Level" },
                    { 180, false, 55, "Education" },
                    { 181, true, 56, "Brain" },
                    { 93, false, 24, "you study" },
                    { 92, true, 23, "was " },
                    { 91, false, 23, "had been" },
                    { 90, false, 23, "would" },
                    { 89, false, 23, "is" },
                    { 88, false, 22, "so she watch" },
                    { 87, false, 22, "that she watch" },
                    { 86, false, 22, "her watch" },
                    { 85, true, 22, "her to watch" },
                    { 84, false, 21, "has often been" },
                    { 83, true, 21, "have often been" },
                    { 82, false, 21, "have been often" },
                    { 81, false, 21, "often have been" },
                    { 320, false, 70, "The Arctic Ocean" },
                    { 319, false, 70, "The Indian Ocean" },
                    { 318, false, 70, "The Atlantic Ocean" },
                    { 317, true, 70, "The Pacific Ocean" },
                    { 316, false, 69, "The Araucaria Forest" },
                    { 315, false, 69, "Waipoua Forest" },
                    { 314, false, 69, "Yakushima Forest" },
                    { 313, true, 69, "The Amazon" },
                    { 94, true, 24, "studying" },
                    { 312, false, 68, "90 meters" },
                    { 95, false, 24, "to study" },
                    { 97, true, 25, "was having" },
                    { 118, false, 30, "going" },
                    { 117, true, 30, "to go" },
                    { 116, true, 29, "like" },
                    { 115, false, 29, "as" },
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
                    { 103, false, 26, "meet" },
                    { 102, false, 26, "met" },
                    { 101, false, 26, "were meeting" },
                    { 100, false, 25, "had been having" },
                    { 99, false, 25, "have been having" },
                    { 98, false, 25, "had" },
                    { 96, false, 24, "are studying" },
                    { 311, false, 68, "100 meters" },
                    { 310, false, 68, "110 meters" },
                    { 309, true, 68, "115.7 meters" },
                    { 282, false, 61, "Dog" },
                    { 281, true, 61, "Cat" },
                    { 200, false, 60, "Run to Feature" },
                    { 199, false, 60, "Make money" },
                    { 198, false, 60, "Build a house" },
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
                    { 186, false, 57, "Objects" },
                    { 185, false, 57, "Subjects" },
                    { 184, false, 56, "Hardwork" },
                    { 183, false, 56, "Lidership" },
                    { 182, false, 56, "Opacity" },
                    { 283, false, 61, "Cow" },
                    { 284, false, 61, "Goat" },
                    { 285, true, 62, "2-16 years" },
                    { 286, false, 62, "1-4 years" },
                    { 308, false, 67, "Vegeterian" },
                    { 307, true, 67, "Omnivorous" },
                    { 306, false, 67, "Herbivorous" },
                    { 305, false, 67, "Carnivorous" },
                    { 304, false, 66, "Vegeterian" },
                    { 303, false, 66, "Omnivorous" },
                    { 302, true, 66, "Herbivorous" },
                    { 301, false, 66, "Carnivorous" },
                    { 300, false, 65, "Vegeterian" },
                    { 299, false, 65, "Omnivorous" },
                    { 279, false, 125, "Canada" },
                    { 298, false, 65, "Herbivorous" },
                    { 296, false, 64, "Oil" },
                    { 295, false, 64, "Salt" },
                    { 294, false, 64, "Sugar" },
                    { 293, true, 64, "Milk" },
                    { 292, false, 63, "1-2 years" },
                    { 291, false, 63, "2-16 years" },
                    { 290, false, 63, "5-10 years" },
                    { 289, true, 63, "10-13 years" },
                    { 288, false, 62, "5-10 years" },
                    { 287, false, 62, "16-24 years" },
                    { 297, true, 65, "Carnivorous" },
                    { 280, false, 125, "Moscow" }
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
                name: "IX_Histories_PassedTestId",
                table: "Histories",
                column: "PassedTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserId",
                table: "Histories",
                column: "UserId");

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
                name: "Histories");

            migrationBuilder.DropTable(
                name: "UserAnswers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PassedTests");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AssignTests");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
