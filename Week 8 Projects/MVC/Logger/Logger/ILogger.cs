using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal interface ILogger
    {
        //Interface method. Does not have a body. This is by default abstract. The body is provided by the "implement class"
        void Log(string message);
    }
}
