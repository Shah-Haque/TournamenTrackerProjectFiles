using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;
using TrackerLibrary.Models;
using System.Net.Mail;

namespace TrackerLibrary
{
   public static class EmailLogic
   {
        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string> { to }, new List<string>(), subject, body);
        }

        /// <summary>
        /// This will send the emails to users 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void SendEmail(List<string> to, List<string> bcc, string subject, string body)
        {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"),GlobalConfig.AppKeyLookup("senderDisplayName"));
            
            MailMessage mail = new MailMessage();
            foreach (string email in to)
            {
                mail.To.Add(email); 
            }
            foreach (string email in bcc)
            {
                mail.Bcc.Add(email);
            }
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            client.Send(mail);
        }
   }
}