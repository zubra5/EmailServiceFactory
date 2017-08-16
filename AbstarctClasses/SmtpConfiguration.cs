using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServiceFactory.AbstarctClasses
{
    abstract class SmtpConfiguration
    {
        public string Server { get; set; }

        public string Port { get; set; }              

        public virtual string ConnectionString { get { return $"Host Name={Server};Port={Port};Authentication=Anonymous"; } }
       
    }
}
