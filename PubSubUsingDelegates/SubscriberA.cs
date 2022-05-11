using System;

namespace PubSubUsingDelegates
{
    public class SubscriberA
    {
        public void OnMessageReceived(object o, MessageEventArgs e)
        {
            Console.WriteLine($"Message received by Subscriber A - {e.Message}");
        }
    }
}
