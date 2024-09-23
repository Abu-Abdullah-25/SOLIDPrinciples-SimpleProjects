public class EmailService
{
    public static void SendEmail(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }
}
