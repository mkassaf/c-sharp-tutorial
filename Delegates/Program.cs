using System;
using System.Threading;
using System.Threading.Tasks;
using Delegates.Model;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StudnetList studnetList = new StudnetList();

                studnetList.OnAdd += UpdateView;
                studnetList.OnRemove += UpdateRemoveView;

                Task.Run(()=> {
                    int i = 0;
                    while (true)
                    {
                        Thread.Sleep(1000);
                        //Check ---
                        studnetList.Add(new Student(i++, "Mustafa", 95));
                    }

                });
                studnetList.Add(new Student(0, "Mustafa", 95));
                studnetList.Add(new Student(0, "Ahmad", 86));
                studnetList.Add(new Student(0, "Rami", 74));

                Student student = studnetList.GetItem(1);
                Console.WriteLine($"studnet -- {student}");
                Console.WriteLine($"studnet -- {studnetList.GetItem(1)}");
                Console.WriteLine($"studnet -- {studnetList.GetItem(2)}");

                studnetList.RemoveAt(0);
                studnetList.RemoveAt(0);
                studnetList.RemoveAt(0);

                Console.ReadKey();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void UpdateRemoveView(Student student)
        {
            Console.WriteLine($"student is removed : {student}");
        }

        private static void UpdateView(Student student)
        {
            Console.WriteLine($"student is added : {student}");
        }

        static void CallDDD()
        {
            Console.WriteLine("A new Element is added to the list  1");
        }

        static void CallDDD2()
        {
            Console.WriteLine("A new Element is added to the list  2");
        }

    }
}
