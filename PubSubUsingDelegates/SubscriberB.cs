using System;

namespace PubSubUsingDelegates
{
    public class SubscriberB
    {
        public void OnMessageReceived(object o, MessageEventArgs e)
        {
            Console.WriteLine($"Message received by Subscriber B - {e.Message}");
        }
    }
}
