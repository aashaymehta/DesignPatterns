namespace AbstractFactory
{
    public class OfficialIvr : Notification
    {
        public string PushNotification()
        {
            return "This is official ivr notification";
        }
    }

    public class PersonalIvr : Notification
    {
        public string PushNotification()
        {
            return "This is personal ivr notification";
        }
    }
}
