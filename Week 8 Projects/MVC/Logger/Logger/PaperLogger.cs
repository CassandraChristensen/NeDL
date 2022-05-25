using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class PaperLogger : ILogger
    {
        //implement ilogger interface
        public void Log (string message)
        {
            Console.WriteLine("Inside Log method of PaperLogger ");
            LogToPaper(message);
        }

        //private method used in public log implementation of interface
        private void LogToPaper(string message)
        {
            Console.WriteLine("Method: LogToPaper, Test: {0}", message);
        }
    }
}
