using System;
using System.Collections.Generic;

namespace Day01.Day03
{
    class EmployeesObj
    {
        static void Main(string[] args)
        {
           
                EmployeeData();
            Console.ReadLine();
        }

        public static void EmployeeData()
        {
            Console.WriteLine("Please enter no.of employees do you want to enter");
            int size = int.Parse(Console.ReadLine());
            //by Using List
            // List<Employee> employees = new List<Employee>();
            Employee[] employees = new Employee[size];
            //by using Array
            for (int i=0;i<size;i++)
            {
                Employee emp = CreateEmployee();
                // employees.Add(emp);
                employees[i] = emp;
            }
            Console.WriteLine(" Employee Details:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee Id : {employee.EmpID}\n Employee Name : {employee.EmpName}\nEmployee Address : {employee.EmpAddress}\nEmployee DOB : {employee.EmpDOB}");
                Console.WriteLine("================================================");
            }
        }

        public static Employee CreateEmployee()
        {
            Employee obj = new Employee();
            var id = HelperClass.GetNumber("Enter Employee Id");
            var Name = HelperClass.GetString("Enter Employee Name");
            var EmpAddress = HelperClass.GetString("Enter Employee Address");
            var EmpDOB = HelperClass.GetDate("Enter Employee Emp Date Of Birth");
            obj.EmpID = id;
            obj.EmpName = Name;
            obj.EmpAddress = EmpAddress;
            obj.EmpDOB = EmpDOB;
            return obj;
        }
    }
}
