using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class CloudLogger : ILogger
    {

        //implement my interface
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of CloudLogger");
            LogToCloud(message);
        }

        //Private method, will only be able to be accessed by my public Log() method. 
        private void LogToCloud(string message)
        {
            Console.WriteLine("Method: LogToCloud, Test: {0}", message);
        }
    }
}
