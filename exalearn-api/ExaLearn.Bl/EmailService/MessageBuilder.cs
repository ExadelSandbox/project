using ExaLearn.Dal.Entities;
using Shared.Enums;
using System;
using System.Net.Mail;

namespace ExaLearn.Bl.EmailService
{
    public static class MessageBuilder
    {
        public static MailMessage GenerateMessageForUserAsync(
            User user,
            LevelType levelType,
            DateTime expirationDate,
            string action
            )
        {
            return CreateEmailMessage(user, levelType, expirationDate, action);
        }

        public static MailMessage CreateEmailMessage(
            User user,
            LevelType levelType,
            DateTime expirationDate,
            string action
            )
        {
            var from = new MailAddress("athleteunitelyselenidetests@gmail.com", "supportExaLearn-api");
            var to = new MailAddress(user.UserName);
            var fullName = $"{user.FirstName} {user.LastName}";
            var message = GenerateMessageTemplate(from, to, levelType, expirationDate, fullName, action);

            return message;
        }

        public static MailMessage GenerateMessageTemplate(
            MailAddress from,
            MailAddress to,
            LevelType levelType,
            DateTime expirationDate,
            string fullName,
            string action
            )
        {
            var emailBodyGenerator = EmailBodyGenerator(action, fullName, to, levelType, expirationDate);

            var message = new MailMessage(from, to)
            { 
                Subject = emailBodyGenerator.Subject,
                Body = emailBodyGenerator.Body,
                IsBodyHtml = true
            };

            return message;
        }

        public static MailMessage EmailBodyGenerator(string action, string fullName, MailAddress email, LevelType levelType, DateTime expirationDate)
        {
            MailMessage mailMessage = new();

            switch (action) {
                case "assignEng":
                    mailMessage.Subject = "You are assigned to a test";
                    mailMessage.Body = $"<div> <h2> Hello {fullName}</h2>" +
                    $"<h3>{email}</h3> <h4> You have been assigned a {levelType} test on the Exalearn.ru resource." +
                    $"<br>The expiration date of the test is {expirationDate.ToShortDateString()}. " +
                    $"You must complete the test before the expiration date, otherwise the test will not be valid.</h4></div>";
                    break;
                case "checkEng":
                    mailMessage.Subject = "Your a test results";
                    mailMessage.Body = $"<div> <h2> Hello {fullName} </h2> <h3>{email}</h3>" +
                    $"<h4> Your {levelType} test has been validated. To find out the test result, " +
                    $"go to the resource Exalearn.ru </h4> </div>";
                    break;
                case "assignRus":
                    mailMessage.Subject = "Приглашение на тест";
                    mailMessage.Body = $"<div> <h2> Привет {fullName}</h2>" +
                     $"<h3>{email}</h3> <h4> Ты получил {levelType} тест в Exalearn.ru resource." +
                     $"<br>Окончания теста в {expirationDate.ToShortDateString()}. " +
                     $"Вы должны пройти тест до истечения срока, иначе тест не будет действительным!</h4></div>";
                    break;
                case "checkRus":
                    mailMessage.Subject = "Результат теста";
                    mailMessage.Body = $"<div> <h2> Привет {fullName} </h2> <h3>{email}</h3>" +
                    $"<h4> Твой { levelType } тест был проверен. Чтобы узнать результат, " +
                    $"перейдите на ресуртс Exalearn.ru </h4> </div>";
                    break;
            }
            return mailMessage;
        }
    }
}
