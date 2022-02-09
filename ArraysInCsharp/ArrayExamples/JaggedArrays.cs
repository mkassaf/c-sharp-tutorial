using System;
namespace ArraysInCsharp.ArrayExamples
{
    public class JaggedArrays
    {
        public JaggedArrays()
        {
        }


        public void Run()
        {
            Console.WriteLine("_____ Jagged array _____");
            //In C#, jagged array is also known as "array of arrays" because its elements are arrays. The element size of jagged array can be different.

            //Declaration of Jagged array
            //Let's see an example to declare jagged array that has two elements.

            int[][] matrix = new int[3][];

            matrix[0] = new int[4] { 11, 21, 56, 78 };
            matrix[1] = new int[] { 42, 61, 37, 41, 59, 63 };
            matrix[2] = new int[2];
            matrix[2][0] = 1;
            matrix[2][1] = 2;

            foreach (int []array in matrix)
            {
                Console.WriteLine(" Len is " + array.Length);
                foreach(int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
