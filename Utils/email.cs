using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
namespace Nave_Project2.Utils
{
    public class Email
    {
        private static string pswd = "dswsbzaazwfnkrdn";
        public static void SendMail(string ToAddress, string subject, string content, string FromAddress)
        {
            SmtpClient client = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(FromAddress, Email.pswd)
            };
            try
            {
                client.Send(FromAddress, ToAddress, subject, content);
            } catch (SmtpException e)
            {
                throw e;
            }
        }
    }
}