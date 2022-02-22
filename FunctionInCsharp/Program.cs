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


            Search_For_The_First();
        }

        public static int Search_For_The_First()
        {
            string text;
            int num = 0;
            Console.Write("Enter a Text:");
            text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                //if(c >='0' && c <= '9')
                if ((text[i] >= '0' && text[i] <= '9'))
                {
                    num *= 10;
                    num += c - '0'; // 0 equivalent 48
                    if (!(text[i + 1] >= '0' && text[i + 1] <= '9'))
                    {
                        break;
                    }

                }
            }


            return num;
        }


    }
}
