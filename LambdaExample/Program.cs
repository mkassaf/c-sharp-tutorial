using System;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Any lambda expression can be converted to a delegate type. 
             * The delegate type to which a lambda expression can be converted is defined by the types of its parameters and return value.
             * 
             * Action  -- If a lambda expression doesn't return a value, it can be converted to one of the Action delegate types; 
             * Func    -- otherwise, it can be converted to one of the Func delegate types
             * 
             * */


            /**
             * int GetFive()
             * {
             *   return 5;
             * }
             */
            Func<int> GetFive =() => 5;

            Console.WriteLine(GetFive());

            Action PrintLine = () => {
                Console.WriteLine("____________________");
                Console.WriteLine("____________________");
            };


            /*
             * void PrintValue(int value) 
             * {
             *   Console.WriteLine($"The value is {value}")
             * }
             * 
             * */
            Action<int> PrintValue = value => Console.WriteLine($"The value is {value}");





            /*
             * int GetSquerSize(int length) 
             * {
             *   return length * length;
             * }
             * 
             * */
            Func<int, int> GetSquerSize = (length) => length * length;
            


            Func<int, int, int> GetRectSize = (length, width) => length * width;


            Func <int, bool> IsOdd = (value) =>
            {
                if(value%2 == 1)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(GetFive());

            PrintLine();

            PrintValue(5);

            Console.WriteLine(GetSquerSize(5));

            Console.WriteLine(GetRectSize(5, 9));

            Console.WriteLine($" 5 is odd? {IsOdd(5)}");

            Console.WriteLine($" 4 is odd? {IsOdd(4)}");

        }
    }
}
