using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatesExample delegatesExample = new DelegatesExample();
            delegatesExample.CleanDelegateFun += Clean;
            delegatesExample.CleanDelegateFun += End;
            delegatesExample.Execute();
        }

        public static void End()
        {
            Console.WriteLine("End ... ");
        }
        public static void Clean()
        {
            Console.WriteLine("Clean ... ");
        }
    }
}
