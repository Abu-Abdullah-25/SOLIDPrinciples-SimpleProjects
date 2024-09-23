public class SMSService : INotification
{
    // Method to send SMS
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }
}
