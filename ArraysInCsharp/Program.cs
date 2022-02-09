using System;
using ArraysInCsharp.ArrayExamples;


namespace ArraysInCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            SimpleArray simpleArray = new SimpleArray();
            simpleArray.Run();

            MultidimensionalArrays multidimensional = new MultidimensionalArrays();
            multidimensional.Run();

            JaggedArrays jaggedArrays = new JaggedArrays();
            jaggedArrays.Run();

            Params parmExample = new Params();
            parmExample.Run();

            ArrayClass arrayClass = new ArrayClass();
            arrayClass.Run();

            Test test = new Test(4);

        }
    }


    class Test
    {

        public Test(int data)
        {

        }

    }
    
}


