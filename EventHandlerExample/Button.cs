using System;
namespace EventHandlerExample
{
    public class Button
    {
        public int ID { get; set; }
        public Button()
        {
        }

        public event EventHandler buttonEvent;
        public void Click()
        {
            if(buttonEvent != null)
            {
                buttonEvent(this, EventArgs.Empty);
            }

        }
    }
}
