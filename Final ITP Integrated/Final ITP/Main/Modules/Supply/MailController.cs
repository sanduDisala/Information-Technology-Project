using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;


namespace VB_Supplier.com.mail
{
    class MailController
    {
        List<Mail> Mails = new List<Mail>();
        string username;
        string password;

        public MailController(string p1, string p2)
        {
            username = p1;
            password = p2;
        }

        public List<Mail> GetAllMails()
        {
            WebClient objclient = new WebClient();
            string response = null;
            XmlDocument xdoc = new XmlDocument();

            try
            {
                objclient.Credentials = new NetworkCredential(username, password);
                response = Encoding.UTF8.GetString(objclient.DownloadData("https://mail.google.com/mail/feed/atom"));
                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\">", "<feed>");
                xdoc.LoadXml(response);
                foreach (XmlNode node1 in xdoc.SelectNodes("feed/entry"))
                {
                    Mail m = new Mail();
                    m.From = node1.SelectSingleNode("author/email").InnerText;
                    m.Title = node1.SelectSingleNode("title").InnerText;
                    m.Summary = node1.SelectSingleNode("summary").InnerText;
                    Mails.Add(m);
                }
                return Mails;
            }
            catch
            {

            }
            return null;
        }
    }
}
