﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectOrientedExample
{
    class Program
    {

        //1- Count all objects created from this class

        //3- Write a code that prints 1 to 10 5 times in parallel (5 threads running together in parallel and each thread prints from 1 to 10).

        //== vs equal
        // Reverse a string

        public void CountdownEvent()
        {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} :: {i}");
                    //Write on file 
                    //Thread.Sleep(100);
                }
      
            //1000 ms

        }

        /**
         * 
         * Unstarted
Runnable (Ready to run)
Running
Not Runnable
Dead (Terminated)

        */

        static void Main(string[] args)
        {
            Program program1 = new Program();
            //Program program2 = new Program();

            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} ThreadState {Thread.CurrentThread.ThreadState}");//Running 
            ThreadStart newThread = new ThreadStart(program1.CountdownEvent);

            Thread t1 = new Thread(newThread);
            Thread t2 = new Thread(new ThreadStart(program1.CountdownEvent));

            Console.WriteLine($" Thread {t1.ManagedThreadId} ThreadState {t1.ThreadState}");//Unstarted - Initilze the DB
            Console.WriteLine($" Thread {t2.ManagedThreadId} ThreadState {t2.ThreadState}");//Unstarted - Copy file from somewher --- 
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t1.Start();// Runable -> run -> 1000 ms
            t2.Start();// Runable -> run -> 1000 ms

            /*
            var task = Task.Run(() => {
                Console.WriteLine($" Thread {t1.ManagedThreadId} ThreadState {t1.ThreadState}");//WaitSleepJoin
                Console.WriteLine($" Thread {t2.ManagedThreadId} ThreadState {t2.ThreadState}");//WaitSleepJoin
                Console.WriteLine($"Task.Run Thread {Thread.CurrentThread.ManagedThreadId} ThreadState {Thread.CurrentThread.ThreadState}");//Background
            });

            task.Wait();
            */

            //--> 0

            //Console.WriteLine($" Thread {t1.ManagedThreadId} ThreadState {t1.ThreadState}");
            //Console.WriteLine($" Thread {t2.ManagedThreadId} ThreadState {t2.ThreadState}");

            for (int i = 0; i < 10; i++)
            {
               
                //Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} :: {i}");
                Thread.Sleep(100);
            }
            //--> 1000 ms

            //Console.WriteLine($" Thread {t1.ManagedThreadId} ThreadState {t1.ThreadState}");//Stopped
            //Console.WriteLine($" Thread {t2.ManagedThreadId} ThreadState {t2.ThreadState}");//Stopped
        }


    }


}
