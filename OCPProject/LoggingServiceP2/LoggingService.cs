public class LoggingService
{
    private readonly ILogging _Logging;

    public LoggingService(ILogging Logging)
    {
        _Logging = Logging;
    }

    public void Log(string message)
    {
        _Logging.Log(message);
    }



}
