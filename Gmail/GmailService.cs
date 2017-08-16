using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;


namespace EmailServiceFactory.Gmail
{
    class GmailService : Service
    {      
        public override bool? Connect()
        {
            Console.WriteLine(Config.ConnectionString);
            return true;
        }
    }
}
