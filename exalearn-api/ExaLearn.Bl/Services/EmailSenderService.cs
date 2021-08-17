using ExaLearn.Bl.Interfaces;
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
            var from = new MailAddress("artem@gmail.com", "Tom");
            var to = new MailAddress("userexa@mailnesia.com");
            var m = new MailMessage(from, to)
            {
                Subject = "ТестПисьмо",
                Body = "<h2>Письмо-тест работы smtp-клиента</h2>",
                IsBodyHtml = true
            };
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("somemail@gmail.com", "mypassword"),
                EnableSsl = true
            };

            await smtp.SendMailAsync(m);
            Console.WriteLine("Письмо отправлено");
        }
    }
}
