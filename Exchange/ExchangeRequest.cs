using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;


namespace EmailServiceFactory.Exchange
{
    class ExchangeRequest: Request
    {
        public override void Do()
        {
            Console.WriteLine("It is Exchange Request");
        }
    }
}
