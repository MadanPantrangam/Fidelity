
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day05
{
    class parent
    {
        public void NonVFunc()
        {
            Console.WriteLine("Dont be expected Modified!");
        }

        public virtual void TestFunc()
        {
            Console.WriteLine("Test Func from Base!");
        }
    }
    class child : parent
    {
        public override void TestFunc()
        {
            Console.WriteLine("Test Func from child!");
        }
    }

    static class ParentFactory
    {
        public static parent GetObject(string name)
        {
            parent obj = null;
            if(name.ToLower() == "parent")
            {
                obj = new parent();
            }
            else
            {
                obj = new child();
            }
            return obj;
        }
    }
    class MethodOverRiding
    {
        static void Main(string[] args)
        {
            //parent obj = new child();
           // obj.TestFunc();

            Console.WriteLine("Tell me Which Class U want parent or child");
            string className = Console.ReadLine();

            parent obj = ParentFactory.GetObject(className);
            obj.TestFunc();
                Console.ReadLine();

        }
    }
}


