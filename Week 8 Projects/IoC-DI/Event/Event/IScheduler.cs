using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal interface IScheduler
    {
        //This is my interface method. It is abstract and does not include a body. 
        //The body will be included in the implementation. 
        //I will be injecting this into the ProductService class. 
        void Schedule(string message);
    }
}
