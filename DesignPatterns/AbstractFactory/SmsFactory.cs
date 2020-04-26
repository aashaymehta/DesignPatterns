using System;

namespace AbstractFactory
{
    public class SmsFactory : NotificationFactory
    {
        public override Notification GetEmailNotifications(string notificationType)
        {
            throw new NotImplementedException();
        }

        public override Notification GetIvrNotifications(string notificationType)
        {
            throw new NotImplementedException();
        }

        public override Notification GetSmsNotifications(string notificationType)
        {
            if (string.IsNullOrEmpty(notificationType))
                return null;

            switch (notificationType.ToLower())
            {
                case "official":
                    return new OfficialSms();

                case "personal":
                    return new PersonalSms();

                default:
                    return null;
            }
        }
    }
}
