using System.Net.Mail;
using System.Threading.Tasks;

namespace RingoMedia.Services
{
    public class EmailService
    {
        private readonly SmtpClient _smtpClient;

        public EmailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var mailMessage = new MailMessage("Mohamedsamirdev@gmail.com", to, subject, body);
            await _smtpClient.SendMailAsync(mailMessage);
        }
    }

}
