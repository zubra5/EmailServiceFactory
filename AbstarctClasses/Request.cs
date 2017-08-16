using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServiceFactory.AbstarctClasses
{
    abstract class Request
    {
        public virtual void Do()
        {
            Console.WriteLine("Do Request");
        }
    }
}
