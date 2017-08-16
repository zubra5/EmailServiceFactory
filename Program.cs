using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.Gmail;
using EmailServiceFactory.Exchange;


namespace EmailServiceFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client(new GmailFactory());
            Client client = new Client(new ExchangeFactory());
            client.Run();
            Console.ReadKey();
        }
    }
}
