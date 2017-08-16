using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailServiceFactory.AbstarctClasses;

namespace EmailServiceFactory
{
    class Client
    {
        private EmailFactory _factory;
        public Client(EmailFactory factory) {
            _factory = factory;
        }

        public void Run() {
            Service service= _factory.CreateService();
            service.Config = _factory.CreateSmtpConfiguration();
            service.Connect();
            service.PushRequest(_factory.CreateRequest());            
        }
    }
}
