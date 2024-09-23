public class EventLoggingService
{

    // Method to log to EventLog
    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}
