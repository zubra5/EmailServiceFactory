using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;


namespace EmailServiceFactory.Exchange
{
    class ExchangeFactory: EmailFactory
    {
        public override Request CreateRequest()
        {
            return new ExchangeRequest();
        }

        public override Service CreateService()
        {
            return new ExchangeService();
        }

        public override SmtpConfiguration CreateSmtpConfiguration()
        {
            return new ExchangeSmtpConfiguration();
        }
    }
}
