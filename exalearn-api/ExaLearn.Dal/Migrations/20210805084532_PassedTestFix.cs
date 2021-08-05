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

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "PassedTests");

            migrationBuilder.AlterColumn<int>(
                name: "AssignTestId",
                table: "PassedTests",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
                    { 82, null, 2, 1, "I dont know when Helen _____ back." },
                    { 81, null, 2, 1, "Your eyes are red – _____?" },
                    { 80, null, 2, 1, "We _____ to the tennis club since we moved here." },
                    { 79, null, 2, 1, "Dad wont mind us borrowing the car, will he? No, I _____" },
                    { 78, null, 2, 1, "The stairs _____ quite steep, so be careful how you go down." },
                    { 77, null, 2, 1, "The interviewer started off _____ me why I wanted the job." },
                    { 76, null, 2, 1, "The taxi will be here in a couple of minutes. We _____ get ready to go." },
                    { 50, null, 0, 3, "Discuss your favorite holiday." },
                    { 49, null, 0, 3, "Describe your childhood pet." },
                    { 83, null, 2, 1, "I _____ an interview because Id worked there before." },
                    { 48, null, 0, 3, "Talk about your happiest memory. " },
                    { 46, null, 0, 3, "Describe a famous person, such as an athlete, actor, or singer. Describe their appearance. " },
                    { 40, null, 3, 2, "After ______, you should take a shower." },
                    { 39, null, 3, 2, "I enjoy _______ in the office." },
                    { 38, null, 3, 2, "Try _____ forget." },
                    { 37, null, 3, 2, "I don't know ________." },
                    { 36, null, 3, 2, "I went to the supermarket _____ milk." },
                    { 35, null, 3, 2, "You need a key ____ the box." },
                    { 34, null, 3, 2, "He _____ the answers during his English test." },
                    { 33, null, 3, 2, "She always listens _______ music on her phone" },
                    { 47, null, 0, 3, "Describe your favorite place using as much detail as you can. " },
                    { 32, null, 3, 2, "Have you heard the news? Jane ________ have a baby!" },
                    { 84, null, 2, 1, "When I asked what was wrong, _____" },
                    { 86, null, 2, 2, "What are the people discussing?" },
                    { 5, null, 1, 1, "Joe ___ a good driver" },
                    { 6, null, 1, 1, "Look! The boys ___ running!" },
                    { 7, null, 1, 1, "\"Be\" verb in past simple" },
                    { 8, null, 1, 1, "I ___ at home yesterday" },
                    { 9, null, 1, 1, "There ___ a one apple left" },
                    { 10, null, 1, 1, "___ did she go?" },
                    { 405, null, 4, 3, "Meaning of life" },
                    { 404, null, 4, 3, "tell us about Platos cave" },
                    { 403, null, 4, 3, "Why we live on this earth?" },
                    { 85, null, 2, 1, "Steven _____ the wallet." },
                    { 402, null, 4, 3, "Life after death" },
                    { 95, null, 2, 2, "What are the people discussing?" },
                    { 94, null, 2, 2, "What does the professor contrast in his lecture?" },
                    { 93, null, 2, 2, "According to the professor, what is ragtime?" },
                    { 92, null, 2, 2, "What does the speaker mainly discuss?" },
                    { 91, null, 2, 2, "In addition to Annie Oakley, which other famous person traveled with Buffalo Bill?" },
                    { 90, null, 2, 2, "What is the woman referring to when she states, That was in 1883?" },
                    { 89, null, 2, 2, "What is the talk mainly about?" },
                    { 88, null, 2, 2, "Which duty does the man like the least?" },
                    { 87, null, 2, 2, "What is the woman referring to when she states, that sounds like fun?" },
                    { 401, null, 4, 3, "What do you think about happiness" },
                    { 31, null, 3, 2, "We spend a lot of time _____ the internet." },
                    { 30, null, 3, 1, "She asked if I would like ______ on a date with her." },
                    { 29, null, 3, 1, "She looks ______ a secretary." },
                    { 58, null, 2, 1, "If you could change one rule that your family has, what would you change?" },
                    { 57, null, 2, 1, "What do you like best about school?" },
                    { 56, null, 2, 1, "What is your best quality or greatest strength?" },
                    { 55, null, 2, 1, "What is something that makes your family special?" },
                    { 54, null, 2, 1, "If you could be invisible for a day, what would you do?" },
                    { 53, null, 2, 1, "What does a typical day look like for you" },
                    { 52, null, 2, 1, "What do you want me to know about you?" },
                    { 51, null, 2, 1, "What can I, as your teacher, do to help you this year?" },
                    { 45, null, 0, 3, "Can you tell about your favorite animal?" },
                    { 59, null, 2, 1, "What do you enjoy doing with your family?" },
                    { 44, null, 0, 3, "Can you tell about your first friend?" },
                    { 42, null, 0, 3, "Can you tell about nature?" },
                    { 41, null, 0, 3, "Lets talk about Great Britain. What do you know about this country?" },
                    { 20, null, 1, 2, "The biggest ocean on the planet?" },
                    { 19, null, 1, 2, "The largest forest in the world?" },
                    { 18, null, 1, 2, "How tall is the tallest tree?" },
                    { 17, null, 1, 2, "Humans are: " },
                    { 16, null, 1, 2, "Cows are: " },
                    { 15, null, 1, 2, "Wolfs are: " },
                    { 14, null, 1, 2, "The main ingredient of the butter?" },
                    { 43, null, 0, 3, "Can you tell about summer holidays?" },
                    { 60, null, 2, 1, "What is the best gift you have ever given?" },
                    { 61, null, 2, 2, "What are three things that you do every day?" },
                    { 62, null, 2, 2, "If you were a teacher, and the kids in your class would not listen to you, what would you do??" },
                    { 28, null, 3, 1, "He met her at school. They have been friends _____ years." },
                    { 27, null, 3, 1, "Tomorrow is Saturday so she ________ work. It's her day off." },
                    { 26, null, 3, 1, "He didn't remember that we ________ before." },
                    { 25, null, 3, 1, "When the postman came, I _________ a shower." },
                    { 24, null, 3, 1, "You can't pass your grammar test without ________." },
                    { 23, null, 3, 1, "We knew that she ______ waiting for the the results of her English test." },
                    { 11, null, 1, 2, "The most common animal?" },
                    { 21, null, 3, 1, "I ______ to that restaurant. The food is very good." },
                    { 75, null, 2, 3, "Past tense themes" },
                    { 74, null, 2, 3, "Money" },
                    { 73, null, 2, 3, "Greetings & introductions" },
                    { 72, null, 2, 3, "Describing people" },
                    { 71, null, 2, 3, "Icebreakers" },
                    { 70, null, 2, 2, "What do you want to be when you grow up?" },
                    { 69, null, 2, 2, "If you could change your name, would you? If so, what name would you choose?" },
                    { 68, null, 2, 2, "Where is your favorite place in the world?" },
                    { 67, null, 2, 2, "If you could make one rule that everyone in the world had to follow, what rule would you make? Why?" },
                    { 66, null, 2, 2, "What superpower would you like to have and why?" },
                    { 65, null, 2, 2, "What is the hardest thing about being a kid?" },
                    { 64, null, 2, 2, "How would the world be different if animals could talk?" },
                    { 63, null, 2, 2, "Are you a good friend? Why do you think so?" },
                    { 12, null, 1, 2, "Cats' lifespan?" },
                    { 22, null, 3, 1, "Her parents didn't want ________ watch T.V." }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 17, false, 5, "are" },
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
                    { 144, true, 36, "to buy" },
                    { 128, true, 32, "is going to" },
                    { 145, false, 37, "they do want" },
                    { 147, false, 37, "what do they want" },
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
                    { 152, false, 38, "aren't" },
                    { 151, false, 38, "to don't" },
                    { 150, false, 38, "don't to" },
                    { 149, true, 38, "not to" },
                    { 148, false, 37, "what are they wanting" },
                    { 146, true, 37, "what they want" },
                    { 323, false, 76, "should better" },
                    { 127, false, 32, "will" },
                    { 125, false, 32, "should" },
                    { 105, false, 27, "wouldn't" },
                    { 104, true, 26, "had met" },
                    { 103, false, 26, "meet" },
                    { 102, false, 26, "met" },
                    { 101, false, 26, "were meeting" },
                    { 100, false, 25, "had been having" },
                    { 99, false, 25, "have been having" },
                    { 98, false, 25, "had" },
                    { 97, true, 25, "was having" },
                    { 96, false, 24, "are studying" },
                    { 95, false, 24, "to study" },
                    { 94, true, 24, "studying" },
                    { 93, false, 24, "you study" },
                    { 92, true, 23, "was " },
                    { 91, false, 23, "had been" },
                    { 106, false, 27, "mustn't" },
                    { 126, false, 32, "would" },
                    { 107, true, 27, "doesn't have to" },
                    { 109, false, 28, "until" },
                    { 124, false, 31, "for" },
                    { 123, false, 31, "by" },
                    { 122, false, 31, "to" },
                    { 121, true, 31, "on" },
                    { 120, false, 30, "to went" },
                    { 119, false, 30, "go" },
                    { 118, false, 30, "going" },
                    { 117, true, 30, "to go" },
                    { 116, true, 29, "like" },
                    { 115, false, 29, "as" },
                    { 114, false, 29, "the same like" },
                    { 113, false, 29, "the same as" },
                    { 112, false, 28, "many" },
                    { 111, false, 28, "since" },
                    { 110, true, 28, "for" },
                    { 108, false, 27, "hasn't" },
                    { 90, false, 23, "would" },
                    { 324, false, 76, "better" },
                    { 326, true, 77, "by asking" },
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
                    { 367, false, 87, "Having a birthday" },
                    { 366, false, 87, "Unpacking books" },
                    { 365, true, 87, "Unwrapping presents" },
                    { 380, false, 90, "The date William Cody was more widely known" },
                    { 364, false, 86, "Working in a library" },
                    { 381, false, 91, "William Cody" },
                    { 383, false, 91, "Chief Sitting Bull" },
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
                    { 382, true, 91, "Queen Victoria" },
                    { 325, false, 77, "in asking" },
                    { 363, false, 86, "Attaching bar codes" },
                    { 361, true, 86, "Getting presents" },
                    { 341, false, 81, "did you cry" },
                    { 340, false, 80, "is belong" },
                    { 339, false, 80, "belong" },
                    { 338, false, 80, "are belonging" },
                    { 337, true, 80, "have belonged" },
                    { 336, false, 79, "not" },
                    { 335, false, 79, "suppose" },
                    { 334, true, 79, "suppose not" },
                    { 333, false, 79, "dont suppose it" },
                    { 332, false, 78, "isnt" },
                    { 331, false, 78, "is" },
                    { 330, false, 78, "be" },
                    { 329, true, 78, "are" },
                    { 328, false, 77, "ask" },
                    { 327, false, 77, "to ask" },
                    { 342, false, 81, "have you cried" },
                    { 362, false, 86, "Purchasing books" },
                    { 343, true, 81, "have you been crying" },
                    { 345, true, 82, "will be" },
                    { 360, false, 85, "admitted stealed" },
                    { 359, true, 85, "admitted stealing" },
                    { 358, false, 85, "admitted steal" },
                    { 357, false, 85, "admitted to steal" },
                    { 356, false, 84, "she explained me the problem" },
                    { 355, false, 84, "he explained me the problem" },
                    { 354, true, 84, "the problem was explained to me" },
                    { 353, false, 84, "I was explained the problem" },
                    { 352, false, 83, "neednt had" },
                    { 351, false, 83, "neednt have had" },
                    { 350, true, 83, "didnt need to have" },
                    { 349, false, 83, "neednt have" },
                    { 348, false, 82, "will" },
                    { 347, false, 82, "can" },
                    { 346, false, 82, "is" },
                    { 344, false, 81, "you been crying" },
                    { 89, false, 23, "is" },
                    { 88, false, 22, "so she watch" },
                    { 87, false, 22, "that she watch" },
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
                    { 71, false, 18, "100 meters" },
                    { 55, false, 14, "Salt" },
                    { 72, false, 18, "90 meters" },
                    { 74, false, 19, "Yakushima Forest" },
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
                    { 76, false, 19, "The Araucaria Forest" },
                    { 75, false, 19, "Waipoua Forest" },
                    { 73, true, 19, "The Amazon" },
                    { 170, false, 53, "Normal" },
                    { 54, false, 14, "Sugar" },
                    { 52, false, 13, "1-2 years" },
                    { 32, false, 8, "were" },
                    { 31, false, 8, "is" },
                    { 30, false, 8, "will be" },
                    { 29, true, 8, "was" },
                    { 28, false, 7, "has" },
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
                    { 33, false, 9, "will be" },
                    { 53, true, 14, "Milk" },
                    { 34, false, 9, "am" },
                    { 36, true, 9, "is" },
                    { 51, false, 13, "2-16 years" },
                    { 50, false, 13, "5-10 years" },
                    { 49, true, 13, "10-13 years" },
                    { 48, false, 12, "5-10 years" },
                    { 47, false, 12, "16-24 years" },
                    { 46, false, 12, "1-4 years" },
                    { 45, true, 12, "2-16 years" },
                    { 44, false, 11, "Goat" },
                    { 43, false, 11, "Cow" },
                    { 42, false, 11, "Dog" },
                    { 41, true, 11, "Cat" },
                    { 40, false, 10, "How many" },
                    { 39, false, 10, "Which" },
                    { 38, false, 10, "Who" },
                    { 37, true, 10, "Where" },
                    { 35, false, 9, "are" },
                    { 171, false, 53, "Ugly" },
                    { 172, false, 53, "Bad" },
                    { 173, false, 54, "Drink" },
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
                    { 296, false, 64, "Oil" },
                    { 295, false, 64, "Salt" },
                    { 294, false, 64, "Sugar" },
                    { 293, true, 64, "Milk" },
                    { 308, false, 67, "Vegeterian" },
                    { 292, false, 63, "1-2 years" },
                    { 309, true, 68, "115.7 meters" },
                    { 311, false, 68, "100 meters" },
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
                    { 312, false, 68, "90 meters" },
                    { 310, false, 68, "110 meters" },
                    { 291, false, 63, "2-16 years" },
                    { 290, false, 63, "5-10 years" },
                    { 289, true, 63, "10-13 years" },
                    { 188, false, 57, "Relax time" },
                    { 187, true, 57, "Lessons" },
                    { 186, false, 57, "Objects" },
                    { 185, false, 57, "Subjects" },
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
                    { 189, true, 58, "Location" },
                    { 190, false, 58, "Future" },
                    { 191, false, 58, "House" },
                    { 192, false, 58, "Money" },
                    { 288, false, 62, "5-10 years" },
                    { 287, false, 62, "16-24 years" },
                    { 286, false, 62, "1-4 years" },
                    { 285, true, 62, "2-16 years" },
                    { 284, false, 61, "Goat" },
                    { 283, false, 61, "Cow" },
                    { 282, false, 61, "Dog" },
                    { 399, false, 95, "A popular painting among the public" },
                    { 281, true, 61, "Cat" },
                    { 199, false, 60, "Make money" },
                    { 198, false, 60, "Build a house" },
                    { 197, true, 60, "Buy a new car" },
                    { 196, true, 59, "Snatch" },
                    { 195, false, 59, "Make money" },
                    { 194, false, 59, "Relax" },
                    { 193, false, 59, "Hunt" },
                    { 200, false, 60, "Run to Feature" },
                    { 400, false, 95, "The most valuable painting in the museum" }
                });

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
                table: "Answers",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 405);

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
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.AlterColumn<int>(
                name: "AssignTestId",
                table: "PassedTests",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "PassedTests",
                type: "text",
                nullable: true);

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
