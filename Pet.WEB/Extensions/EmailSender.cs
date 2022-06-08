using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace Pet.WEB.Extensions
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            #region Mail Message tanimlari
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("minikpetler@hotmail.com");
            mailMessage.To.Add(email);
            mailMessage.Body = htmlMessage;
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            #endregion


            #region Smtp Ayarlari


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.office365.com";
            smtpClient.Credentials = new System.Net.NetworkCredential("minikpetler@hotmail.com", "Kovboy99f.i");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            #endregion

            try
            {
                smtpClient.Send(mailMessage);

            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
    }
}
