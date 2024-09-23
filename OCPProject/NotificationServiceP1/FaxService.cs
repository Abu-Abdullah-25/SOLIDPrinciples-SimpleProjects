public class FaxService : INotification
{
    // Method to send Fax
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}
