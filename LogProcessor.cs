using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public abstract class LogProcessor
    {
        public LogProcessor nextLogProcessor;
        public LogProcessor(LogProcessor logProcessor)
        {
            nextLogProcessor = logProcessor;         
        }

        public abstract void Log(string logLevel, string message);
    }
}
