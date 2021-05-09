using MailKit.Security;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.Text;

namespace ThirdPartyServices.SendMail
{
    public class SendMailService : ISendMailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly IConfiguration _config;
        public SendMailService(IConfiguration config)
        {
            _config = config;
            _smtpClient = new SmtpClient();
            _smtpClient.Connect(_config["SMTP_Auth:Host"], Int32.Parse(_config["SMTP_Auth:Port"]), SecureSocketOptions.StartTls);
            _smtpClient.Authenticate(_config["SMTP_Auth:Email"], _config["SMTP_Auth:Pwd"]);
        }
        public Task<bool> SendMailConfirmPwd()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SendMailNotify(string subject, string body, string receiver)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config["SMTP_Auth:Email"]));
            email.To.Add(MailboxAddress.Parse(receiver));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            await _smtpClient.SendAsync(email);
            //_smtpClient.Disconnect(true);
            return true;
        }

        public Task<bool> SendMailResetPwd()
        {
            throw new NotImplementedException();
        }
    }
}
