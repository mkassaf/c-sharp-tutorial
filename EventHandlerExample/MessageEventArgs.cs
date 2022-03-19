using System;
namespace EventHandlerExample
{
    public class MessageEventArgs : EventArgs
    {

        public string Message { get; set; }

        public MessageEventArgs(string Message)
        {
            this.Message = Message;
        }



    }
}
