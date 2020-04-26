namespace AbstractFactory
{
    public abstract class NotificationFactory
    {
        public abstract Notification GetEmailNotifications(string notificationType);

        public abstract Notification GetSmsNotifications(string notificationType);

        public abstract Notification GetIvrNotifications(string notificationType);
    }
}
