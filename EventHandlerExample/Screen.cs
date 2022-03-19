using System;
namespace EventHandlerExample
{
    public class Screen
    {
        public Screen()
        {
        }

        public void DisplayNewMessage(object sender, MessageEventArgs messageEvent)
        {
            MessageReciver tmp = (MessageReciver)sender;
            Console.WriteLine($"A new message {messageEvent.Message} form object with ID {tmp.ID}");
        }

    }
}
