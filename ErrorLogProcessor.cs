using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public class ErrorLogProcessor :LogProcessor
    {
        public ErrorLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }
        public override void Log(string logLevel, string message)
        {
            if (logLevel == LogLevel.ERROR)
            {
                Console.WriteLine("ERROR: "+ message);
            }
            else
            {
                nextLogProcessor.Log(logLevel, message);
            }
        }
    }
}
