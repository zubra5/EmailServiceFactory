using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServiceFactory.AbstarctClasses
{
    abstract class Service
    {
        public SmtpConfiguration Config { get; set; }
        public virtual void PushRequest(Request request) {
            request.Do();
        }

        public virtual bool? Connect() => null;
    }
}
