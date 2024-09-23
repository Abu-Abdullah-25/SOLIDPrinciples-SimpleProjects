using System;
using System.Transactions;




class Program
{
    static void Main()
    {
        #region NotificationService
        // Create an instance of the NotificationService
        NotificationService notificationService = new NotificationService(new EmailService());

        // Send an email
        notificationService.SendNotification("john@example.com", "Welcome to our service!");

        notificationService = new NotificationService(new SMSService());

        // Send an SMS
        notificationService.SendNotification("+123456789", "Your OTP code is 1234.");

        notificationService = new NotificationService(new FaxService());

        // Send a fax
        notificationService.SendNotification("123-456-789", "Fax Message: Important document.");

        notificationService = new NotificationService(new TelegramService());

        // Send a telegram
        notificationService.SendNotification("123-456-789", "Telegram Message: Important message.");

        notificationService = new NotificationService(new WhatsappService());

        // Send a whatsapp
        notificationService.SendNotification("123-456-789", "Whatsapp Message: Important message.");

        notificationService = new NotificationService(new SnappChatService());

        // Send a SnappChat
        notificationService.SendNotification("123-456-789", "SnappChat Message: Important message.");

        notificationService = new NotificationService(new TikTokService());

        // Send a SnappChat
        notificationService.SendNotification("123-456-789", "TikTok Message: Important message.");

        #endregion

        #region LoggingService
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService(new FileLoggingService());

        // Log to File
        LoggingService.Log("File-Error Occured line xxx.");


        LoggingService = new LoggingService(new EventLoggingService());

        // Log to Event Log
        LoggingService.Log("Event-Error Occured line xxx.");

        LoggingService = new LoggingService(new DatabaseLoggingService());

        // Log to Database
        LoggingService.Log("DB-Error Occured line xxx.");
        #endregion
        Console.ReadKey();

    }
}
