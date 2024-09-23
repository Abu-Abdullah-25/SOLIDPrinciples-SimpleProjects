public class WhatsappService : INotification
{
    // Method to send whatsapp
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Whatsapp to {to}: {message}");
    }
}
