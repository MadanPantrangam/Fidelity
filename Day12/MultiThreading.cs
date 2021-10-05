using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day01.Day11.Day12
{
    class MultiThreading
    {
        static void bigTaskFunc()
        {
            string name = Thread.CurrentThread.Name;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Task Function of {name} With Lot of Work");
                Thread.Sleep(1000);
            }
        }
        static void smallTaskFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Small Task Function With Lot of Work");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            // SingleThreadedAppDemo();
            //MultiThreadindAppDemo();
             callingMultipleThreads();
            //backgroundThreads();
            Console.ReadLine();
        }

        private static void backgroundThreads()
        {
            Thread t1 = new Thread(bigTaskFunc);
            t1.IsBackground = true;
            t1.Start();
            smallTaskFunc();
        }

        private static void callingMultipleThreads()
        {
            Thread t1 = new Thread(bigTaskFunc);
            t1.Name = "Thread 1";
            Thread t2 = new Thread(bigTaskFunc);
            t2.Name = "Thread 2";
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
        }

        private static void MultiThreadindAppDemo()
        {
            Thread t1 = new Thread(bigTaskFunc);
            t1.Start();
            smallTaskFunc();
        }

        private static void SingleThreadedAppDemo()
        {
            bigTaskFunc();
            smallTaskFunc();
        }
    }
}
