using System;
namespace ArraysInCsharp
{
    public class Params
    {
        public Params()
        {
        }
        public void Print(params int[] values) // try params object[] values
        {
            Console.WriteLine("Inside Params.Print");
            Console.WriteLine("The len of the params is " + values.Length);

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + ", ");
            }
            /**
            foreach (int value in values)
            {
                Console.Write(value +  ", ");
            }
            **/
           
        }
        public void Run()
        {
            Console.WriteLine("_____ params _____");
            //In C#, params is a keyword which is used to specify a parameter that takes variable number of arguments.
            //It is useful when we don't know the number of arguments prior.
            //Only one params keyword is allowed and no additional parameter is permitted after params keyword in a function declaration.
            Print(1,2,3,4,5,6,7,8,9);

            //OR
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            Print(array);


        }
    }
}
