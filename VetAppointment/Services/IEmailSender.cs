using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace VetAppointment.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(string email, string subject, string message);
          
    }
    public class EmailService:IMailService
    {
        private IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string email,string subject,string content)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("aplikacja.weterynaryjna@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = content;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("aplikacja.weterynaryjna@gmail.com", "Vet_2021");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
