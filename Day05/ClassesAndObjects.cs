using System;
namespace Day01.Day05
{

    

    class Employee
    {
        public int EmpId { get; set; } = 6133094;
        public string EmpName { get; set; } = "Madan Pantrangam";
        public string EmpAddress { get; set; } = "Mallam, Andhra Pradesh";
        public long EmpNumber { get; set; } = 7093599231;
    }

    class ClassDemo
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Employee 1 Details!");
            Console.WriteLine($"Employee {employee.EmpName} from {employee.EmpAddress} his Contact Number is {employee.EmpNumber} his Id is {employee.EmpId}");
            Employee temp = new Employee
            {
                EmpId = 123,
                EmpName="Suneel Pantrangam",
                EmpAddress="Nellore Andhra Pradesh",
                EmpNumber=9876543210

            };
            Console.WriteLine($"Employee {temp.EmpName} from {temp.EmpAddress} his Contact Number is {temp.EmpNumber} And his Id is {temp.EmpId}");

            Console.ReadLine();
        }

    }
}
