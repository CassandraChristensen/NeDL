using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class RetirementScheduler : IScheduler
    {
        //implement interface
        public void Schedule(string message)
        {
            Console.WriteLine("Inside Schedule method for RetirementScheduler class");
            SchedulerForRetirement(message);
        }

        private void SchedulerForRetirement(string message)
        {
            Console.WriteLine("Method: ScheduleForRetirement, Text: " + message);
        }
    }
}
