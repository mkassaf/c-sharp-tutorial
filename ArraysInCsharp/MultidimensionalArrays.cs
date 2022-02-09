using System;
namespace ArraysInCsharp
{
    public class MultidimensionalArrays
    {
        public MultidimensionalArrays()
        {
        }

        public void Print(int[,] matrix)
        {
            Console.WriteLine("Enter MultidimensionalArrays.Print ");
            int row = matrix.GetLength(0);//->Gets the first dimension size

            int col = matrix.GetLength(1);//->Gets the second dimension size
            Console.WriteLine("first dimension size: " + row);
            Console.WriteLine("first dimension size: " + col);
            for(int i = 0; i< row; i++)
            {
                Console.Write("Row " + i + ": ");
                for(int j=0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " " );
                }
                Console.WriteLine();
            }

        }
        public void Run()
        {
            Console.WriteLine("Multi dimensional Arrays");
            int[,] arr = new int[3, 3];//declaration of 2D array  
            arr[0, 1] = 10;//initialization  
            arr[1, 2] = 20;
            arr[2, 0] = 30;

            Console.WriteLine("Array len: " + arr.Length);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }


            //C# Multidimensional Array Example: Declaration and initialization at same time
            //There are another ways to initialize the 2D array

            //We can omit the array size.
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //We can omit the new operator also.
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] matrix = { { 1, 2, 3, 4, 5 }, { 6,7,8,9,10 }, { 11,12,13,14,15 } };
            Print(matrix);
        }
    }
}
