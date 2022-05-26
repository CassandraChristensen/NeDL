using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class WeddingScheduler : IScheduler

    {

        //Implement my interface method
        public void Schedule(string message)
        {
            Console.WriteLine("Inside Schedule method of Wedding class.");
            ScheduleForWedding(message);
        }

        //private method for use in the Schedule method. 
        private void ScheduleForWedding(string message)
        {
            Console.WriteLine("Method: ScheduleForWedding, Text: " + message);
        }
    }
}
