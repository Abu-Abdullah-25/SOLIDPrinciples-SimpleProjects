public class TelegramService : INotification
{
    // Method to send Telegram
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Telegram to {to}: {message}");
    }
}
