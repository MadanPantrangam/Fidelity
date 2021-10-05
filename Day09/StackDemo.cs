using System;
using System.Collections.Generic;
using System.Linq;
using Day01.Day03;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day09
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            // StackExample();
            queueExample();
            Console.ReadLine();
        }

        private static void queueExample()
        {
            /*
Works like FIFO manner(First In First Out).
Element are added to the Queue using Enqueue method and retrieved using Dequeue method. Like Stack U cannot access it using [] operator. Contains and Clear methods are there even here....
*/
            Queue<string> items = new Queue<string>();
            do
            {
                if (items.Count == 3)
                {
                    items.Dequeue();
                }
                items.Enqueue(HelperClass.GetString("What Do you Want See today?"));
                Console.WriteLine("UR Recent List  : ");
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            } while (true);
        }

        private static void StackExample()
        {
            //Stack is used to store the data in the form of LIFO(Last In First Out). Elements are added from the top and fills the column. The first element added will be the last element to be pulled out.
            //Push and Pop methods are used to add and retrieve the data from the Stack. U cannot use indexer in stack.
            //Count, Contains(), Clear()
            //Peek() vs Pop() methods
            Stack<string> pages = new Stack<string>();
            pages.Peek();
            pages.Push("Home Page");
            pages.Push("Contact PAge");
            pages.Push("Call PAge");
            pages.Push("Message Page");
            foreach (var page in pages)
            {
                Console.WriteLine(page);
            }

            Console.WriteLine("Now Removing The Pages");
            Console.WriteLine(pages.Pop() + "is moved out");
            Console.WriteLine(pages.Pop() + "is moved out");
            Console.WriteLine(pages.Pop() + "is moved out");
            Console.WriteLine(pages.Pop() + "is moved out");
        }
    }
}
