using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class FileLogger : ILogger
    {

        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger.");
            LogToFile(message);
        }

        private void LogToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Test: {0}", message);
        }
    }
}
