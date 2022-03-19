

using System;
using System.IO;

namespace EventHandlerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            MessageReciver messageReciver = new MessageReciver();
            messageReciver.ID = 10;


            Screen screen = new Screen();
            Database database = new Database();

            messageReciver.onReiveEvent += screen.DisplayNewMessage;
            messageReciver.onReiveEvent += database.EvenetHandling;



            messageReciver.Recive("Hello");


            Button store = new Button();
            Button delete = new Button();

            store.buttonEvent += StoreInDB;
            delete.buttonEvent += Delete;

            store.Click();
            delete.Click();
          

            **/


            string manyLines = @"This is line one
This is line two
Here is line three
The penultimate line is line four
This is the final, fifth line.";




            using (var reader = new StringReader(manyLines))
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);

            }




                //Code

                Console.ReadKey();
        }

        private static void Delete(object sender, EventArgs e)
        {
            ///
        }

        private static void StoreInDB(object sender, EventArgs e)
        {
            ///
        }
    }
}
