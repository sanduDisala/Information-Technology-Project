using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB_Supplier.com.mail
{
    class MailReader
    {
        public String mailContent;
        String MAIL_FORMAT_ERROR = "Sorry, Ivalid Email Format.";

        public MailReader(String mailContent)
        {
            this.mailContent = mailContent;
        }

        public String getOrderID() 
        {
            if (mailContent.Split(';').Length > 3) {
                return mailContent.Split(';')[0].Replace("OrderID:","");
            }
            return MAIL_FORMAT_ERROR;    
        }

        public String getModel()
        {
            if (mailContent.Split(';').Length > 3)
            {
                return mailContent.Split(';')[1].Replace("Model:", "");
            }
            return MAIL_FORMAT_ERROR;  
        }

        public String getQuentity()
        {
            if (mailContent.Split(';').Length > 3)
            {
                return mailContent.Split(';')[2].Replace("Quentity:", "");
            }
            return MAIL_FORMAT_ERROR; 
        }
    }
}
