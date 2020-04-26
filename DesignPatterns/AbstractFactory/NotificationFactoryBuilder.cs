namespace AbstractFactory
{
    public static class NotificationFactoryBuilder
    {
        // Decides which factory to return based on user input. Instead of returning concrete implementation
        // it returns a Factory object
        public static NotificationFactory GetNotificationFactory(string notificationType)
        {
            if(string.IsNullOrEmpty(notificationType))
            {
                return null;
            }

            switch (notificationType.ToLower())
            {
                case "email":
                    return new EmailFactory();
                    
                case "sms":
                    return new SmsFactory();

                case "ivr":
                    return new IvrFactory();

                default:
                    return null;
            }
        }
    }
}
