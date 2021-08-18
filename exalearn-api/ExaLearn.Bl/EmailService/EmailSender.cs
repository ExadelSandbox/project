using ExaLearn.Dal.Entities;
using Shared.Enums;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ExaLearn.Bl.EmailService
{
    public static class EmailSender
    {
        public static async Task SendEmailAsync(
            User user,
            LevelType levelType,
            DateTime expirationDate,
            bool isAssing
            )
        {
            var m = MessageBuilder.GenerateMessageForUserAsync(user, levelType, expirationDate, isAssing);

            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("athleteunitelyselenidetests@gmail.com", "Z123456x"),
                EnableSsl = true
            };

            await smtp.SendMailAsync(m);
        }
    }
}
