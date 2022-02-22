using System;
namespace FunctionInCsharp
{
    public class Functions
    {
        public Functions()
        {
        }

        public void Print(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        public void CallByValue(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the CallByValue function " + val);
        }
        public void CallByRefrence(ref int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the CallByRefrence function " + val);
        }

        /**
         * 
         * C# Out Parameter
         * C# provides out keyword to pass arguments as out-type. 
         * It is like reference-type, except that it does not require variable to initialize before passing. 
         * We must use out keyword to pass argument as out-type.
         * It is useful when we want a function to return multiple values.
         * 
         */
        public void CallFunUsingOutParam(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value
            Console.WriteLine("Value inside the CallFunUsingOutParam function " + val);
        }


    }
}
