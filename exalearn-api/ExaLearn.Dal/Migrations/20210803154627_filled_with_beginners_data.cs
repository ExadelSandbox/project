using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class filled_with_beginners_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { false, "14" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { true, "12" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Text",
                value: "16");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Text",
                value: "10");

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 9, true, 3, "Read" },
                    { 10, false, 3, "Rat" },
                    { 11, false, 3, "Red" },
                    { 12, false, 3, "Road" },
                    { 13, false, 4, "Swim" },
                    { 14, false, 4, "Swam" },
                    { 15, true, 4, "Swum" },
                    { 16, false, 4, "Slim" }
                });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Capital of the England?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "QuestionType", "Text" },
                values: new object[] { 1, "How many major verb tenses are in english?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LevelType", "QuestionType", "Text" },
                values: new object[] { 1, 1, "Second verb form of \"read\"?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LevelType", "QuestionType", "Text" },
                values: new object[] { 1, 1, "Third verb form of \"swim\"?" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FileUrl", "LevelType", "QuestionType", "Text" },
                values: new object[,]
                {
                    { 13, null, 1, 2, "Dogs' lifespan?" },
                    { 5, null, 1, 1, "Joe ___ a good driver" },
                    { 6, null, 1, 1, "Look! The boys ___ running!" },
                    { 7, null, 1, 1, "\"Be\" verb in past simple" },
                    { 8, null, 1, 1, "I ___ at home yesterday" },
                    { 9, null, 1, 1, "There ___ a one apple left" },
                    { 10, null, 1, 1, "___ did she go?" },
                    { 25, null, 0, 3, "Can you tell about your favorite animal?" },
                    { 24, null, 0, 3, "Can you tell about your first friend?" },
                    { 12, null, 1, 2, "Cats' lifespan?" },
                    { 23, null, 0, 3, "Can you tell about summer holidays?" },
                    { 21, null, 0, 3, "Lets talk about Great Britain. What do you know about this country?" },
                    { 20, null, 1, 2, "The biggest ocean on the planet?" },
                    { 19, null, 1, 2, "The largest forest in the world?" },
                    { 18, null, 1, 2, "How tall is the tallest tree?" },
                    { 17, null, 1, 2, "Humans are: " },
                    { 16, null, 1, 2, "Cows are: " },
                    { 11, null, 1, 2, "The most common animal?" },
                    { 14, null, 1, 2, "The main ingredient of the butter?" },
                    { 22, null, 0, 3, "Can you tell about nature?" },
                    { 15, null, 1, 2, "Wolfs are: " }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 17, false, 5, "are" },
                    { 51, false, 13, "2-16 years" },
                    { 52, false, 13, "1-2 years" },
                    { 53, true, 14, "Milk" },
                    { 54, false, 14, "Sugar" },
                    { 55, false, 14, "Salt" },
                    { 56, false, 14, "Oil" },
                    { 57, true, 15, "Carnivorous" },
                    { 58, false, 15, "Herbivorous" },
                    { 59, false, 15, "Omnivorous" },
                    { 60, false, 15, "Vegeterian" },
                    { 61, false, 16, "Carnivorous" },
                    { 62, true, 16, "Herbivorous" },
                    { 63, false, 16, "Omnivorous" },
                    { 50, false, 13, "5-10 years" },
                    { 64, false, 16, "Vegeterian" },
                    { 66, false, 17, "Herbivorous" },
                    { 67, true, 17, "Omnivorous" },
                    { 68, false, 17, "Vegeterian" },
                    { 69, true, 18, "115.7 meters" },
                    { 70, false, 18, "110 meters" },
                    { 71, false, 18, "100 meters" },
                    { 72, false, 18, "90 meters" },
                    { 73, true, 19, "The Amazon" },
                    { 74, false, 19, "Yakushima Forest" },
                    { 75, false, 19, "Waipoua Forest" },
                    { 76, false, 19, "The Araucaria Forest" },
                    { 77, true, 20, "The Pacific Ocean" },
                    { 78, false, 20, "The Atlantic Ocean" },
                    { 65, false, 17, "Carnivorous" },
                    { 49, true, 13, "10-13 years" },
                    { 48, false, 12, "5-10 years" },
                    { 47, false, 12, "16-24 years" },
                    { 18, true, 5, "is" },
                    { 19, false, 5, "am" },
                    { 20, false, 5, "he" },
                    { 21, true, 6, "are" },
                    { 22, false, 6, "am" },
                    { 23, false, 6, "they" },
                    { 24, false, 6, "is" },
                    { 25, false, 7, "will be" },
                    { 26, false, 7, "be" },
                    { 27, true, 7, "was/were" },
                    { 28, false, 7, "has" },
                    { 29, true, 8, "was" },
                    { 30, false, 8, "will be" },
                    { 31, false, 8, "is" },
                    { 32, false, 8, "were" },
                    { 33, false, 9, "will be" },
                    { 34, false, 9, "am" },
                    { 35, false, 9, "are" },
                    { 36, true, 9, "is" },
                    { 37, true, 10, "Where" },
                    { 38, false, 10, "Who" },
                    { 39, false, 10, "Which" },
                    { 40, false, 10, "How many" },
                    { 41, true, 11, "Cat" },
                    { 42, false, 11, "Dog" },
                    { 43, false, 11, "Cow" },
                    { 44, false, 11, "Goat" },
                    { 45, true, 12, "2-16 years" },
                    { 46, false, 12, "1-4 years" },
                    { 79, false, 20, "The Indian Ocean" },
                    { 80, false, 20, "The Arctic Ocean" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { true, "Cat" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { false, "Dog" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Text",
                value: "Cow");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Text",
                value: "Goat");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Capital of the England");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "QuestionType", "Text" },
                values: new object[] { 2, "The most common animal" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LevelType", "QuestionType", "Text" },
                values: new object[] { 0, 3, "Let’s talk about Great Britain. What do you know about this country?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LevelType", "QuestionType", "Text" },
                values: new object[] { 0, 3, "Can you speak in your micro about nature (2 minutes)?" });
        }
    }
}
