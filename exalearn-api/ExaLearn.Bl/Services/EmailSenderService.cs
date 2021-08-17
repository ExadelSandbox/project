using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ExaLearn.Bl.Services
{
    public static class EmailSenderService
    {
        public static async Task SendEmailAsync()
        {
            var from = new MailAddress("userexa@mailnesia.com","supportExaLearn-api");
            var to = new MailAddress("userexa@mailnesia.com");
            var m = new MailMessage(from, to)
            {
                Subject = "You are assigned to a test",
                Body = "<h2>Check your board for pass a test</h2>",
                IsBodyHtml = true
            };
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("athleteunitelyselenidetests@gmail.com", "Z123456x"),
                EnableSsl = true
            };

            await smtp.SendMailAsync(m);
        }
    }
}
