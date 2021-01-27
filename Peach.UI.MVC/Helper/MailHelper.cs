using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Helper
{
    public class MailHelper
    {
        public static bool SendActivationCode(string Firstname, string mail,Guid ActivationCode)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(mail);
            msg.Subject = "Peach on Activation Code";
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<!DOCTYPE html><html><head><title>LiveInCircle</title></head><body><h2>Merhaba {0} sitemize hoşgeldin</h2><p>Hesabınızı aktifleştirmek için lütfen <a href='http://localhost:52719/Account/ActivationUser/{1}'>link</a>'e tıklayınız</p></body></html>", Firstname,ActivationCode);
            msg.From = new MailAddress("Peach.Proje@outlook.com", "Peach");
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            NetworkCredential credential = new NetworkCredential("Peach.Proje@outlook.com", "e010203,e");
            client.Credentials = credential;
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
