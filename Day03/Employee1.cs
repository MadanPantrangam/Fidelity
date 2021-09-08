using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day03
{
    class Employee1
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            Console.WriteLine("Please Enter Employee Details : ");
            Console.WriteLine("=========================");
            Console.WriteLine("Enter Employee Id : ");
            obj.EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            obj.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Address : ");
            obj.EmpAddress = Console.ReadLine();
            Console.WriteLine("Enter Employee DOB : ");
            obj.EmpDOB = Console.ReadLine();
            Console.WriteLine($"Emplyee Details : \n EmpId : {obj.EmpID} \nEmployee Name : {obj.EmpName}\n Employee Address : {obj.EmpAddress} \nEmployee DOB : {obj.EmpDOB}");
            Console.ReadLine();
        }
    }
}
