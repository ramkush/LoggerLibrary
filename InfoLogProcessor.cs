using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }
        public override void Log(string logLevel, string message)
        {
           if(logLevel == LogLevel.INFO)
            {
                Console.WriteLine("INFO: "+message);
            }
           else
            {
                nextLogProcessor.Log(logLevel, message);
            }
        }
    }
}
