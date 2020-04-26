using System;

namespace AbstractFactory
{
    public class IvrFactory : NotificationFactory
    {
        public override Notification GetEmailNotifications(string notificationType)
        {
            throw new NotImplementedException();
        }

        public override Notification GetIvrNotifications(string notificationType)
        {
            if (string.IsNullOrEmpty(notificationType))
                return null;

            switch (notificationType.ToLower())
            {
                case "official":
                    return new OfficialIvr();

                case "personal":
                    return new PersonalIvr();

                default:
                    return null;
            }
        }

        public override Notification GetSmsNotifications(string notificationType)
        {
            throw new NotImplementedException();
        }
    }
}
