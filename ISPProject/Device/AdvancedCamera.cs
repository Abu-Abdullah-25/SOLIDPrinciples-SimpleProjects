public class AdvancedCamera : IPhotoDevice, IEmailDevice
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }
}
