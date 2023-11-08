using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    internal class SendEmail
    {
        public void sendMail(string to, string body, string subject)
        {
            var from = "luan.neumann@abase.com.br";
            var pass = "************";

            var message = new MailMessage(to, from);

            message.Subject = "Este é um simples ,muito simples email";
            message.Body = "Este é o corpo do email";

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(to, pass)
            };


            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }
    }
}
