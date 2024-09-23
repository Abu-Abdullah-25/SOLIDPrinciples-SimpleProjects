public class NotificationService
{
    private INotification _Notification;

    public NotificationService(INotification Notification)
    {
        _Notification = Notification;
    }

    public void SendNotification(string to, string message)
    {


        _Notification.Send(to, message);


    }

}
