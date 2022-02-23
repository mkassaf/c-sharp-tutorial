using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class ExtraExample
    {


        static async Task Main(string[] args)
        {


            Task<int> task1 = Print($"Welcome to C#");
            var task2 = Print("112");

            Task.WaitAll(task1, task2);
            Console.WriteLine(task1.GetAwaiter().GetResult());
            Console.WriteLine(task2.GetAwaiter().GetResult());

            int result = await Print("Goodbye");//

            Console.WriteLine(result);


            //---//


        }

        static async Task<int> Print(string message)
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine($"Start message is {message} :: Thread id [{Thread.CurrentThread.ManagedThreadId}]");
                Thread.Sleep(1000);
                Console.WriteLine($"End message is {message} :: Thread id [{Thread.CurrentThread.ManagedThreadId}]");
                return message.Length;
            });

            await task;
            return task.GetAwaiter().GetResult();

        }

        static async Task<string> Print3(string message)
        {
            var task = Task.Run(() =>
            {
                return message;
            });

            await task;
            return task.GetAwaiter().GetResult();

        }
        /**
        static async Task Print(string caller)
        {


            Task awaiter = Task.Run(RunMyJob);
            await awaiter;

        }
        */

        private static void RunMyJob()
        {
            Console.WriteLine($"Enter Print :: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Exit Print  :: {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Run(string caller)
        {
            Console.WriteLine($"Enter Print {caller} :: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Exit Print {caller} :: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}

