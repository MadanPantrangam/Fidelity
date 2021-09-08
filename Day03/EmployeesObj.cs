using System;

namespace Day01.Day03
{
    class EmployeesObj
    {
        static void Main(string[] args)
        {
            EmployeeData();
            Console.ReadLine();
        }

        private static void EmployeeData()
        {
            var Employees = new Employee[5];
            Employees[0] = new Employee { EmpID = 1, EmpName = "Madan", EmpAddress = "Nellore", EmpDOB = "10-05-1999" };
            Employees[1] = new Employee { EmpID = 2, EmpName = "Suneel", EmpAddress = "Bangalore", EmpDOB = "15-07-1996" };
            Employees[2] = new Employee { EmpID = 3, EmpName = "Ram", EmpAddress = "Sullurpeta", EmpDOB = "02-10-1995" };
            Employees[3] = new Employee { EmpID = 4, EmpName = "Sam", EmpAddress = "Kadapa", EmpDOB = "01-01-2000" };
            Employees[4] = new Employee { EmpID = 5, EmpName = "Rahul", EmpAddress = "Vizag", EmpDOB = "11-06-1999" };

            foreach (var employee in Employees)
            {
                Console.WriteLine($"Employee Id : {employee.EmpID}\n Employee Name : {employee.EmpName}\nEmployee Address : {employee.EmpAddress}\nEmployee DOB : {employee.EmpDOB}");
                Console.WriteLine("================================================");
            }
        }
    }
}
