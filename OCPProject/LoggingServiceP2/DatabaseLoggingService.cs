public class DatabaseLoggingService : ILogging
{
    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}
