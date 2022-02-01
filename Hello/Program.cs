using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World..!");
            Welcom welcom = new Welcom();
            welcom.print();
        }
    }


    class Welcom
    {
        public void print()
        {
            Console.WriteLine("Welcome");
        }
    }
}
