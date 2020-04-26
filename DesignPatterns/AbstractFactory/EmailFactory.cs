using System;
namespace AbstractFactory
{
    public class EmailFactory : NotificationFactory
    {
        public override Notification GetEmailNotifications(string notificationType)
        {
            if (string.IsNullOrEmpty(notificationType))
                return null;

            switch (notificationType.ToLower())
            {
                case "official":
                    return new OfficialEmail();

                case "personal":
                    return new PersonalEmail();

                default:
                    return null;
            }
        }

        public override Notification GetIvrNotifications(string notificationType)
        {
            throw new NotImplementedException();
        }

        public override Notification GetSmsNotifications(string notificationType)
        {
            throw new NotImplementedException();
        }
    }
}
