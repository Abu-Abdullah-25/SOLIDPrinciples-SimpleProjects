public class Smartphone : ISmartPayment
{
    public void MakeCall()
    {
        Console.WriteLine("Making a call.");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }

    public void UseGPS()
    {
        Console.WriteLine("Using GPS.");
    }
}
