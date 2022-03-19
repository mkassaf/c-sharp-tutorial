using System;
namespace EventHandlerExample
{
    public class MessageReciver
    {

        public int ID { get; set; }

        public event EventHandler<MessageEventArgs> onReiveEvent;

        public MessageReciver()
        {
        }


        public void Recive(String Message)
        {
            Console.WriteLine($"Recive a new message {Message}");

            if(onReiveEvent != null)
            {
                onReiveEvent(this, new MessageEventArgs(Message));
            }
            
            
        }

    }
}
