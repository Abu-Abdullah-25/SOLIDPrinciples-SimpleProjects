public class LoggingService
{
    public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

    public void Log(string message, enLoggingType LoggingType)
    {

        if (LoggingType == enLoggingType.ToFile)
        {
            FileLoggingService.Log(message);
        }
        else if (LoggingType == enLoggingType.ToEventLog)
        {
            EventLoggingService.Log(message);
        }
        else if (LoggingType == enLoggingType.ToDatabase)
        {
            DatabaseLoggingService.Log(message);
        }
    }



}
