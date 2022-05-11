using System;

namespace PubSubUsingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher objPub = new Publisher();
            SubscriberA objSubA = new SubscriberA();
            SubscriberB objSubB = new SubscriberB();
            objPub.PublishMessageEvent += objSubA.OnMessageReceived;
            objPub.PublishMessageEvent += objSubB.OnMessageReceived;
            objPub.PublishMessage("New stock value is published");
            Console.Read();
        }
    }
}
