using System;

namespace PubSubUsingDelegates
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}