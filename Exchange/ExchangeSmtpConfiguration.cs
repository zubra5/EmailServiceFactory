using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;


namespace EmailServiceFactory.Exchange
{
    class ExchangeSmtpConfiguration: SmtpConfiguration
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public override string ConnectionString { get { return $"Host Name={Server};Port={Port};Login={Login};Password={Password}"; } }
    }
}
