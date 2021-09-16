
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day07
{
    sealed class TestClass
    {
        public void TestFunc() => Console.WriteLine("Test Func");
    }

    sealed class TestClass1
    {
        private static TestClass cls = new TestClass();
        public void TestFunc()
        {
            cls.TestFunc();
            Console.WriteLine("add some extra features in it");
        }
    }
    class SealedClassDemo 
    {
        static void Main(string[] args)
        {
            TestClass1 cls = new TestClass1();
            cls.TestFunc();
            Console.ReadLine();
        }
    }
}
