public class SMSService
{

    public static void SendSMS(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }
}
