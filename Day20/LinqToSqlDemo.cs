using Day01.Day03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day20
{
    class LinqToSqlDemo
    {
        static DataManagerDataContext context = new DataManagerDataContext();
        static void Main(string[] args)
        {
            // FirstDemo();
            // ShoeinEmployeeWithDept();
            // ShowingEmployeesOfDept("Development");
            // OrderByFirstLetter();
            insertRecord();
            //insertBulkRecords();
            // deleteRecord();
            updateRecord();
            Console.ReadLine();
        
        }

        private static void updateRecord()
        {
            var empData = context.Employees.Where(e => e.DepId == 1).ToList();
            for (int i = 0; i < empData.Count; i++)
            {
                if (i % 3 == 0)
                {
                    empData[i].DepId = 3;
                }
                else
                {
                    empData[i].DepId = 4;
                }
            }
            context.SubmitChanges();

        }

        private static void deleteRecord()
        {
            int id = HelperClass.GetNumber("Enter Id For Delete");
            //var rec = (from emp in context.Employees
            //           where emp.EmpId == id
            //           select emp).SingleOrDefault();

            var rec = context.Employees.FirstOrDefault(e => e.EmpId == id);
            context.Employees.DeleteOnSubmit(rec);
            context.SubmitChanges();
            Console.WriteLine("Employee Deleted!");

        }

        private static void insertBulkRecords()
        {
            XDocument doc = XDocument.Load("Employees.xml");
            var records = (from element in doc.Descendants("Employee")
                           select new Employee
                           {
                               DepId = 1,
                               EmpAddress = element.Element("EmpCity").Value,
                               EmpSalary = int.Parse(element.Element("EmpSalary").Value),
                               EmpName = element.Element("EmpName").Value
                           }).Take(20);
            context.Employees.InsertAllOnSubmit(records);
            context.SubmitChanges();
        }

        private static void insertRecord()
        {
            var emp = new Employee();
            emp.DepId = HelperClass.GetNumber("Enter Department Id");
            emp.EmpName = HelperClass.GetString("Enter Employee Name");
            emp.EmpAddress = HelperClass.GetString("Enter Employee Address");
            emp.EmpSalary = HelperClass.GetNumber("Enter Employee Salary");
            context.Employees.InsertOnSubmit(emp);
            context.SubmitChanges();
        }

        private static void OrderByFirstLetter()
        {
            var groups = from emp in context.Employees
                         group emp by emp.EmpName[0] into g
                         orderby g.Key
                         select g;
            foreach (var gr in groups)
            {
                Console.WriteLine("Employee Name Starting With letter :"+gr.Key);
                foreach (var emp in gr)
                {
                    Console.WriteLine($"{emp.EmpName} from {emp.EmpAddress}");
                }
            }
       }

        private static void ShowingEmployeesOfDept(string v)
        {
            var result = (from dept in context.Depts
                          where dept.DeptName == v
                          select dept.Employees).FirstOrDefault();
            foreach (var item in result)
            {
                Console.WriteLine(item.EmpName);
            }
         }

        private static void ShoeinEmployeeWithDept()
        {
            var result = from emp in context.Employees
                         select new
                         {
                             name = emp.EmpName,
                             dept = emp.Dept.DeptName,
                             salary = emp.EmpSalary
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.name} , {item.dept} , {item.salary}");
            }
        }

        private static void FirstDemo()
        {
            //var com = new DataManagerDataContext();
            //var result = from cst in com.Customers
            // where cst.City == "Bangalore" //one type
            // select cst.CustomerName;
            var data = context.Customers.Where((c) => c.City == "Bangalore").ToList(); //Another type
            foreach (var cst in data)
            {
                Console.WriteLine(cst.CustomerName);
            }

            //var result = from cst in context.Customers
            //             where cst.City == "Bangalore"
            //             select cst.CustomerName;
            //foreach (var cst in result) Console.WriteLine(cst);
        }
    }
}
