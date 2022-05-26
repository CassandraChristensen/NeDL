using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class GraduationScheduler : IScheduler

    {

        public void Schedule(string message)
        {
            Console.WriteLine("In the Schedule Method for GraduationScheduler class");
            ScheduleForGraduation(message);
        }

        private void ScheduleForGraduation(string message)
        {
            Console.WriteLine("Method: ScheduleForGraduation, Text: " + message);
        }


    }
}
