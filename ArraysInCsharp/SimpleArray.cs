using System;
namespace ArraysInCsharp
{
    public class SimpleArray
    {
        public SimpleArray()
        {
        }

        public void PrintArray(int[] arr)
        {
            Console.WriteLine("\nPrinting array elements inside function");
            Console.WriteLine("The array size is : " + arr.Length);
            foreach (int element in arr)
            {
                Console.Write(element + ",");
            }
            Console.WriteLine();
        }

        public void EditArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }

        public void Run()
        {
            Console.WriteLine("Simple Arrays");
            int[] arr = new int[5];//creating array  
            arr[0] = 10;//initializing array  
            arr[2] = 20;
            arr[4] = 30;

            //traversing array  
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            Console.WriteLine();

            //Declaration and Initialization at same time
            //There are 3 ways to initialize array at the time of declaration.
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + ",");
            }
            Console.WriteLine();
            //We can omit the size of array.
            int[] arr3 = new int[] { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + ",");
            }
            Console.WriteLine();
            //We can omit the new operator also.
            int[] arr4 = { 10, 20, 30, 40, 50 };

            //We can also traverse the array elements using foreach loop. It returns array element one by one.
            foreach (int element in arr4)
            {
                Console.Write(element + ",");
            }
            EditArray(arr4);
            PrintArray(arr4);

        }
    }
}
