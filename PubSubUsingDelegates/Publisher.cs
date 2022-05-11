namespace PubSubUsingDelegates
{
    public class Publisher
    {
        public delegate void PublishMessageHandler(object o, MessageEventArgs e);

        public event PublishMessageHandler PublishMessageEvent;

        public void PublishMessage(string message)
        {
            MessageEventArgs messageArgs = new MessageEventArgs();
            messageArgs.Message = message;
            if (PublishMessageEvent != null)
                PublishMessageEvent(this, messageArgs);
        }
    }
}
