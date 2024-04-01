using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public class DebugLogProcessor :LogProcessor
    {
        public DebugLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }
        public override void Log(string logLevel, string message)
        {
            if (logLevel == LogLevel.DEBUG)
            {
                Console.WriteLine("DEBUG: "+ message);
            }
            else
            {
              
               nextLogProcessor.Log(logLevel, message);
            }
        }
    }
}
