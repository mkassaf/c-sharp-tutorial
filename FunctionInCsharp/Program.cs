using System;

namespace FunctionInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();
            functions.Print("Mustafa");
            int value = 5;
            Console.WriteLine("value before CallByValue is " + value);
            functions.CallByValue(value);
            Console.WriteLine("value after CallByValue is " + value);

            Console.WriteLine("value before CallByRefrence is " + value);
            functions.CallByRefrence(ref value);
            Console.WriteLine("value after CallByRefrence is " + value);

            int unassignedValue;
            //Console.WriteLine("unassignedValue before CallFunUsingOutParam is " + unassignedValue);// Error: CS0165: Use of unassigned local variable 'unassignedValue'
            functions.CallFunUsingOutParam(out unassignedValue);
            Console.WriteLine("unassignedValue after CallFunUsingOutParam is " + unassignedValue);
        }
    }
}
