using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaLearn.Dal.Migrations
{
    public partial class newfieldassignedtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AssignTests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FileUrl", "LevelType", "QuestionType", "Text" },
                values: new object[,]
                {
                    { 126, null, 6, 1, "Tourists -------- when large numbers of middle class people ------- to join the more wealthy aristocratic travellers." },
                    { 148, null, 0, 3, "What is the purpose of the misinformation?" },
                    { 147, null, 0, 3, "Do you think all citizens should be encouraged to do voluntary service overseas so as to understand the problems of poorer countries?" },
                    { 146, null, 0, 3, "Are electric cars better for the environment?" },
                    { 145, null, 6, 2, "Some people argue that certain oriental relaxation techniques ------- yoga and meditation are extremely effective in the treatment of high blood pressure." },
                    { 144, null, 6, 2, "I dont suppose you are telling us the true version of the story, ----------?" },
                    { 143, null, 6, 2, "You would not expect anyone -------- intelligent to make ------ stupid mistake, but he did so." },
                    { 142, null, 6, 2, "The neutral mutation rate is known -------- widely along human chromosomes, -------- to mutational hot and cold regions." },
                    { 141, null, 6, 2, "She failed to get anyone to repair the taps for her at the weekend, -------- could she do it on her own." },
                    { 140, null, 6, 2, "The results of last weekends poll have ------- to be announced and officials say it could be -------- week before they are." },
                    { 139, null, 6, 2, "-------- a celebrity arrives in Istanbul, the first question reporters ask them is ------- they like Istanbul." },
                    { 149, null, 0, 3, "Do people tend to be more violent when they group together? (gangs / mobs / crowds…)" },
                    { 138, null, 6, 2, "My mother is making a steady recovery from flu and ------- hospital by next week." },
                    { 136, null, 6, 2, "A combination of imagination and determination -------- Peter -------- entirely new lines of research concerned with the way animals survive extreme environmental conditions" },
                    { 135, null, 6, 1, "If I -------- the choice of making either an oral or a written report, I -------- the second alternative." },
                    { 134, null, 6, 1, "She keeps saying that she has got -------- patience with kids, but forgets that she didnt have -------- before she gave birth to her own kids." },
                    { 133, null, 6, 1, "Despite my insistence, Adam didnt tell me -------- he didnt like me and my family." },
                    { 132, null, 6, 1, "Im ready to do ---------- I can do to help you - ------- your hardship." },
                    { 131, null, 6, 1, "Soils are the result of -------- interacting processes -------- bring different materials together." },
                    { 130, null, 6, 1, "---------- you have made minimal progress, it is by no means the kind of progress that you need to make." },
                    { 129, null, 6, 1, "Certain serious diseases can be successfully treated -------- detected in an initial stage." },
                    { 128, null, 6, 1, "As the tree was too high to climb, the mischievous boys ---------- their ball down only by throwing sticks at it." },
                    { 127, null, 6, 1, "The wounded hunter -------- on the ground for almost an hour when, coincidentally, he -------- by another hunter, who must have keen eyes" },
                    { 137, null, 6, 2, "The scientist who -------- Dolly the sheep, the worlds first cloned mammal, -------- a licence on Tuesday to clone human embryos for medical research." },
                    { 150, null, 0, 3, "What are the worst consequences of a natural disaster?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 406, false, 126, "have originated / had begun" },
                    { 463, false, 140, "still / each" },
                    { 462, false, 140, "so far / every" },
                    { 461, false, 139, "Until / if" },
                    { 460, false, 139, "Whenever / what" },
                    { 459, true, 139, "Every time / how" },
                    { 458, false, 139, "During / whether" },
                    { 457, true, 138, "will have left" },
                    { 464, false, 140, "already / every other" },
                    { 456, false, 138, "has left" },
                    { 454, false, 138, "could have left" },
                    { 453, false, 137, "will be creating / has granted" },
                    { 452, true, 137, "created / was granted" },
                    { 451, false, 137, " had created / granted" },
                    { 450, false, 137, "has created / has been granted" },
                    { 449, true, 136, "allowed / to develop" },
                    { 448, false, 136, "were allowed / to have developed" },
                    { 455, false, 138, "is leaving" },
                    { 447, false, 136, "have allowed / being developed" },
                    { 465, true, 140, "yet / another" },
                    { 467, true, 141, "nor" },
                    { 483, false, 144, "just as" },
                    { 482, false, 144, "so" },
                    { 481, false, 143, "will you" },
                    { 480, false, 143, "can you" },
                    { 479, true, 143, "are you" },
                    { 478, false, 143, " do I" },
                    { 477, false, 142, "more / than" },
                    { 466, false, 141, "as" },
                    { 476, false, 142, "as / as" },
                    { 474, true, 142, "so / that" },
                    { 473, true, 141, "to vary / leading" },
                    { 472, false, 141, "to have varied / being led" },
                    { 471, false, 141, "varying / led" },
                    { 470, false, 141, "to be varying / to lead" },
                    { 469, false, 141, "so" },
                    { 468, false, 141, "only" },
                    { 475, false, 142, "too / such" },
                    { 446, false, 136, "allow / developing" },
                    { 445, true, 135, "were given / would pick" },
                    { 444, false, 135, "would have given / had picked" },
                    { 422, false, 130, "What" },
                    { 421, false, 129, "before" },
                    { 420, false, 129, "even when" },
                    { 419, true, 129, "if" },
                    { 418, false, 129, "unless" },
                    { 417, false, 128, "may have knocked" },
                    { 416, false, 128, "will have to knock" },
                    { 423, false, 130, "Despite" },
                    { 415, true, 128, "were able to knock" },
                    { 413, true, 127, "had been lying / was spotted" },
                    { 412, false, 127, "will have lain / had been spotted" },
                    { 411, false, 127, "has lain / will be spotted" },
                    { 410, false, 127, "has been lying / is spotting" },
                    { 409, true, 126, "originated / began" },
                    { 408, false, 126, "could have originated / have begun" },
                    { 407, false, 126, "had originated / began" },
                    { 414, false, 128, "would have knocked" },
                    { 424, false, 130, "In addition to" },
                    { 425, true, 130, "While" },
                    { 426, false, 131, " a few / by which" },
                    { 443, false, 135, "had been given / might pick" },
                    { 442, false, 135, "gave / could pick" },
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
                    { 429, false, 131, "most of / which" },
                    { 428, true, 131, "some / that" },
                    { 427, false, 131, "such / as" },
                    { 484, true, 144, "such as" },
                    { 485, false, 144, "both" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AssignTests");
        }
    }
}
