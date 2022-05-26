using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class ProductService
    {
        //Creating instance of a concrete class 
        private readonly IScheduler _scheduler;

        //Passing instance of a concrete class as a parameter using constructor injection 
        public ProductService (IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public void Schedule (string message)
        {
            _scheduler.Schedule(message);
        }
    }
}
