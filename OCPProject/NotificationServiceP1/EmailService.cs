public class EmailService : INotification
{
    // Method to send email
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }

}
