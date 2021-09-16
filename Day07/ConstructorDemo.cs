using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day07
{

    ////Constructor is a sp function that is invoked when an object is being created. It will be responsible 
    //to provide the dependencies of UR object before it becomes usable.
    ////Constructors are not the place to initialize the fields of UR class.
    ////Constructor is helpfull for injecting the dependencies required for the object to be used at its best.
    ////Constructor is a function with the same name of the class and with no return type. However, it can have args. 
    //Constructors with no args is called Default constructors and the others are called Parameterized Constructors.
    ////U can have private constructors if UR intention is not to create objects outside the class. More like a singleton. 
    //However, this is not required now as we have static classes to do the job.
    ////If a class is inherited, the base class constructor should be invoked first before the current constructor is called. 
    //This can be done implicitly(default constructors) or explicitly using base keyword.(base means immediate base class).
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Class Constructor");
        }

        public BaseClass( string name)
        {
            Console.WriteLine($"Base Class With {name} argu");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("Madan")
        {
            Console.WriteLine("Derived Class Constructor");
        }
    }


    class Radio
    {
        public string  Name { get; set; }

        public void Play()
        {
            Console.WriteLine("{0} is Playing!!",Name);
        }
    }

    class Car
    {
        public Car()
        {
            Entertainment = new Radio { Name = "Honada" };
        }

        public Car(Radio radio)
        {
            Entertainment = radio;
        }
        public Radio Entertainment { get; set; }

        public void Run()
        {
            Console.WriteLine("Car is Now in Run Mode");
            Entertainment.Play();
        }
    }
    class ConstructorDemo
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Run();
            //car.Entertainment = new Radio { Name = "Sony" };
            //car.Run();
            DerivedClass obj = new DerivedClass();
            Console.ReadLine();
        }
    }
}
