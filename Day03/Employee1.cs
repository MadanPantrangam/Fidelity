using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day03
{
    public class Employee1
    {

        static void Main(string[] args)
        {
            CreateEmployee();
            Console.ReadLine();
        }

        public static void CreateEmployee()
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
            Console.WriteLine($"Emplyee Details : \n EmpId : {obj.EmpID} \nEmployee Name : {obj.EmpName}\n Employee Address : {obj.EmpAddress} \nEmployee DOB : {obj.EmpDOB}");
            
        }

    }
}
