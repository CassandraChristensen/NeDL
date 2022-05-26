using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class DatabaseLogger : ILogger
    {

        //Implementing the Interface 
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of DatabaseLogger");
            LogToDatabase(message);
        }

        //Private method, will only be able to be accessed by my public Log() method. 
        private void LogToDatabase(string message)
        {
            Console.WriteLine("Method: LogToDatabase, Test: {0}", message);
        }
    }
}
