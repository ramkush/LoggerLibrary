namespace LoggerLibrary
{
    public class Logger
    {
        public static void LogMessage(string logType,string message)
        {
            ErrorLogProcessor errorLogProcessor = new ErrorLogProcessor(null);
            DebugLogProcessor debugLogProcessorObj = new DebugLogProcessor(errorLogProcessor);
            InfoLogProcessor infoLogProcessorObj = new InfoLogProcessor(debugLogProcessorObj);

            infoLogProcessorObj.Log(logType,message);
        }
    }
}
