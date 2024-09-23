public class FileLoggingService : ILogging
{
    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }
}
