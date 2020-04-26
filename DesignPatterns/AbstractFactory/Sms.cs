namespace AbstractFactory
{
    public class OfficialSms : Notification
    {
        public string PushNotification()
        {
            return "This is official sms notification";
        }
    }

    public class PersonalSms : Notification
    {
        public string PushNotification()
        {
            return "This is personal sms notification";
        }
    }
}
