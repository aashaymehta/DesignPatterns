using System;
namespace AbstractFactory
{
    public class OfficialEmail : Notification
    {
        public string PushNotification()
        {
            return "This is official email notification";
        }
    }

    public class PersonalEmail : Notification
    {
        public string PushNotification()
        {
            return "This is personal email notification";
        }
    }
}
