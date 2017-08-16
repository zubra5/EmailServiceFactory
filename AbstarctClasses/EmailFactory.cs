using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServiceFactory.AbstarctClasses
{
    abstract class EmailFactory
    {
        public virtual Request CreateRequest() => null;

        public virtual Service CreateService() => null;

        public virtual SmtpConfiguration CreateSmtpConfiguration() => null;
    }
}
