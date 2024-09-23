public class SnappChatService : INotification
{
    // Method to send whatsapp
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SnappChat to {to}: {message}");
    }
}
