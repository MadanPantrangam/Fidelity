using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day04
{
    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id : ");
            int EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name  :");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Address : ");
            string EmpAddress = Console.ReadLine();
            Console.WriteLine($"Employee {EmpName} Address is {EmpAddress} And His Id is {EmpId}");
            Console.ReadLine();
        }
    }
}
