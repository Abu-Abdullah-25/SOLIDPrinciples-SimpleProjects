using System;



class Program
{
    static void Main()
    {
        #region NotificationService
        //NotificationService notificationService = new NotificationService();

        //// Send an email
        //notificationService.SendNotification("john@example.com", "Welcome to our service!", NotificationService.enNotificationType.Email);

        //// Send an SMS
        //notificationService.SendNotification("+123456789", "Your OTP code is 1234.", NotificationService.enNotificationType.SMS);

        //// Send a fax
        //notificationService.SendNotification("123-456-789", "Fax Message: Important document.", NotificationService.enNotificationType.Fax);

        #endregion

        #region LoggingService
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService();

        // Log to File
        LoggingService.Log("File-Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

        // Log to Event Log
        LoggingService.Log("DB-Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

        // Log to Database
        LoggingService.Log("Event-Error Occured line xxx.", LoggingService.enLoggingType.ToDatabase);
        #endregion


        Console.ReadKey();

    }
}
