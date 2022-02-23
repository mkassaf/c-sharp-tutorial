using System;
using System.Threading;

namespace Delegates
{
    public class DelegatesExample
    {
        public delegate void CleanDelegate();

        public CleanDelegate CleanDelegateFun;
        public DelegatesExample()
        {
        }

        public void Execute()
        {
            Console.WriteLine("Start executing");
            Thread.Sleep(1000);
            Console.WriteLine("Finish executing");
            CleanUp();
        }

        private void CleanUp()
        {
            if(CleanDelegateFun != null)
            {
                CleanDelegateFun();
            }
        }
    }
}
