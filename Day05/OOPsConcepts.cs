using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day05
{
    class Person
    {
        public string Name { get; set; }
    }

    class Student : Person
    {
        public int CurrentClass { get; set; }
    }

    class Sample
    {
        public void PublicFunctio() {
            Console.WriteLine("Public Function");
            PrivateFunction();
        } 
        private  void PrivateFunction() => Console.WriteLine("Private Function");
        internal  void InternalFunction() => Console.WriteLine("Internal Function");
        protected  void ProtectedFunctio() => Console.WriteLine("Protected Function");
        protected internal  void ProtInternalFunctio() => Console.WriteLine("Protected Internal Function");

    }

    class DerivedClass : Sample
    {
        public void CallMyFunction()
        {
            ProtectedFunctio();
        }
    }
    class OOPsConcepts
    {
        static void Main(string[] args)
        {
            //Student stu = new Student() { Name="Madan" , CurrentClass = 11};
            //Console.WriteLine($"The Name Of the Student is {stu.Name}");
            //Console.WriteLine($"The Cuurent Accademic of the student class is {stu.CurrentClass}");
            Sample obj = new Sample();
            obj.PublicFunctio();
            // obj.PrivateFunction();
            //obj.ProtectedFunctio();
            DerivedClass sam = new DerivedClass();
            sam.CallMyFunction();
            obj = new DerivedClass();
            ((DerivedClass)obj).CallMyFunction();
            obj.InternalFunction();
            obj.ProtInternalFunctio();

            Console.ReadLine();
        }
    }
}
