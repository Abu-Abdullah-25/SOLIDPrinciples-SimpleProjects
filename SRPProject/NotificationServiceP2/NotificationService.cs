public class NotificationService
{
    public enum enNotificationType { Email, SMS, Fax }

    public void SendNotification(string to, string message, enNotificationType NotificationType)
    {

        if (NotificationType == enNotificationType.Email)
        {
            EmailService.SendEmail(to, message);
        }
        else if (NotificationType == enNotificationType.SMS)
        {
            SMSService.SendSMS(to, message);
        }
        else if (NotificationType == enNotificationType.Fax)
        {
            FaxService.SendFax(to, message);
        }
    }

}
