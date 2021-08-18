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
            bool isAssing
            )
        {
            return CreateEmailMessage(user, levelType, expirationDate, isAssing);
        }

        public static MailMessage CreateEmailMessage(
            User user,
            LevelType levelType,
            DateTime expirationDate,
            bool isAssing
            )
        {
            var from = new MailAddress("userexa@mailnesia.com", "supportExaLearn-api");
            var to = new MailAddress(user.UserName);
            var fullName = $"{user.FirstName} {user.LastName}";
            var message = GenerateMessageTemplate(from, to, levelType, expirationDate, fullName, isAssing);

            return message;
        }

        public static MailMessage GenerateMessageTemplate(
            MailAddress from,
            MailAddress to,
            LevelType levelType,
            DateTime expirationDate,
            string fullName,
            bool isAssing
            )
        {
            var message = new MailMessage(from, to)
            {
                Subject = isAssing ? "You are assigned to a test" : "Your a test results",
                Body = isAssing
                    ? $"<div> <h2> Hello {fullName}</h2>" +
                    $"<h3>{to}</h3> <h4> You have been assigned a {levelType} test on the Exalearn.ru resource." +
                    $"<br>The expiration date of the test is {expirationDate.ToShortDateString()}. " +
                    $"You must complete the test before the expiration date, otherwise the test will not be valid.</h4></div>"
                    :
                    $"<div> <h2> Hello {fullName} </h2> <h3>{to} </h3>" +
                    $"<h4> Your { levelType } test has been validated. To find out the test result, " +
                    $"go to the resource Exalearn.ru </h4> </div>",
                IsBodyHtml = true
            };

            return message;
        }
    }
}
