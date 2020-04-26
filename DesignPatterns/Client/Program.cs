using System;
using AbstractFactory;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory client implementation
            var notificationFactory = NotificationFactoryBuilder.GetNotificationFactory("email");
            if (notificationFactory != null)
            {
                var emailNotification = notificationFactory.GetEmailNotifications("personal");
                if (emailNotification != null)
                {
                    var personalEmailNotificationMessage = emailNotification.PushNotification();
                    Console.WriteLine(personalEmailNotificationMessage);
                }
            }

            notificationFactory = NotificationFactoryBuilder.GetNotificationFactory("sms");
            if (notificationFactory != null)
            {
                var smsNotification = notificationFactory.GetSmsNotifications("official");
                if (smsNotification != null)
                {
                    var officialSmsNotificationMessage = smsNotification.PushNotification();
                    Console.WriteLine(officialSmsNotificationMessage);
                }
            }

            notificationFactory = NotificationFactoryBuilder.GetNotificationFactory("ivr");
            if (notificationFactory != null)
            {
                var ivrNotification = notificationFactory.GetIvrNotifications("personal");
                if (ivrNotification != null)
                {
                    var personalIvrNotificationMessage = ivrNotification.PushNotification();
                    Console.WriteLine(personalIvrNotificationMessage);
                }
            }

            Console.ReadLine();
        }
    }
}
