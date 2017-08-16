using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;


namespace EmailServiceFactory.Exchange
{
    class ExchangeService : Service
    {
       // public new ExchangeSmtpConfiguration Config{ get; set; }
        public override  bool? Connect()
        {
            
            Console.WriteLine("This is ExcahngeService");
            Console.WriteLine(Config.ConnectionString);
            return null;
        }
    }
}
