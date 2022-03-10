using System;

namespace ExceptionExmaple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             // Execption - > EmptyPathExecption -> NullPathExecption


            try
            {
                Console.WriteLine($"GetFileType() :: {GetFileType("")}");
                //Copy 
            }
            catch (NullPathException e)
            {
                Console.WriteLine($" NullPathException  {e.Message} : {e.StackTrace}");
            }
            catch (EmptyPathException e)
            {
                Console.WriteLine($" EmptyPathException  {e.Message} : {e.StackTrace} ");
            }
            
            catch (InvalidPathExecption e)
            {
                Console.WriteLine($" InvalidPathExecption  {e.Message}: {e.StackTrace}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" Exception  {e.Message}: {e.StackTrace}");

            }
            finally
            {
                Console.WriteLine("Allways");
            }





            Console.WriteLine("Bye World!");

        }

        static int GetNumber()
        {

            try
            {
                Console.WriteLine("Open connection");
                Console.WriteLine("Connection.Send(); // this method may throw an exception");
                //method(8);
                return 0;

            }
            catch (Exception e)
            {
                //Ex
                Console.WriteLine($"Our exception is {e.Message} :: {e.StackTrace}");
                return -1;
            }
            finally
            {
                Console.WriteLine("Connection.Close();");
            }
        }


        static string GetFileType(string path)
        {
            if(path == null)
            {
                //NullPathExceptionNu
                throw new NullPathException("The path is null");
            }
            else if (path.Equals(String.Empty))
            {
                //EmptyPathException
                throw new EmptyPathException("The path is empty");
            }
            else if(path.IndexOf(".") == -1)
            {
                //InvalidPathExecption
                Exception exception = new InvalidPathExecption("The path is invalid");
                throw exception;
            } else if (path.Length < 3)
            {
                Exception exception = new Exception("Path is short");
                throw exception;
            }

            //we are good
            return "type";


        }

        static void CallMethod(int i)
        {
            method(8);
        }

        static void method(int i)
        {
            i = 0;
            if(i == 0)
            {
            } 
            int tmp = 5 / i;

        }
    }
}
