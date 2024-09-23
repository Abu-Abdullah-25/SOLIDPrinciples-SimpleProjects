public class TikTokService : INotification
{
    // Method to send whatsapp
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending TikTok to {to}: {message}");
    }
}
