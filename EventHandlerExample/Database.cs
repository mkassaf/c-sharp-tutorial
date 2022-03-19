using System;
namespace EventHandlerExample
{
    public class Database
    {
        public Database()
        {
        }


        public void EvenetHandling(object sender, MessageEventArgs messageEvent)
        {
            //Code that stores in DB
            MessageReciver tmp = (MessageReciver)sender;
            Console.WriteLine($"Strong {messageEvent.Message} in DB, form {tmp.ID}");

        }
    }
}
