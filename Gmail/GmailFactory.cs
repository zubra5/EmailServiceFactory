using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;


namespace EmailServiceFactory.Gmail
{
    class GmailFactory: EmailFactory
    {
        public override Request CreateRequest()
        {
            return new GmailRequest();
        }

        public override Service CreateService()
        {          
            return new GmailService();
        }

        public override SmtpConfiguration CreateSmtpConfiguration()
        {
            return new GmailSmtpConfiguration();
        }
    }
}
