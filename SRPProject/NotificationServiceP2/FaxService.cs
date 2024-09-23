public class FaxService
{
    
    public static void SendFax(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}
