using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day01.Day11;
using binary=System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Day01.Day03;

namespace Day01.Day13
{

    class EmployeeActivities : IEmployeeDemo
    {
        private string fileName = "Employees.bin";
        private List<Day11.Employee> _employee=new List<Day11.Employee>();

        public EmployeeActivities()
        {
            serialize();
        }
        private void serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            binary.BinaryFormatter fm = new binary.BinaryFormatter();
            fm.Serialize(fs, _employee);
            fs.Close();
        }
      
        private void deSerialize()
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                binary.BinaryFormatter fm = new binary.BinaryFormatter();
                _employee = fm.Deserialize(fs) as List<Day11.Employee>;
                fs.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
        public void AddNewEmployee(Day11.Employee emp)
        {
            _employee.Add(emp);
            serialize();
        }

        public void DeleteEmployee(int id)
        {
            deSerialize();
            var rec = FindById(id);
            _employee.Remove(rec);
            serialize();
        }

        public List<Day11.Employee> FindByAddress(string address)
        {
            deSerialize();
            var rec = _employee.FindAll((e) => e.Address.Contains(address));
            return rec;
        }

        public Day11.Employee FindById(int id)
        {
            deSerialize();
            var records = _employee.Find((e) => e.EmpId == id);
            if (records == null) Console.WriteLine($"Employee {id} is Not Found");
            return records;
        }

        public List<Day11.Employee> FindByName(string name)
        {
            deSerialize();
            var records = _employee.FindAll((e) => e.Name.Contains(name));
            return records;
        }

        public void UpdateEmployee(Day11.Employee emp)
        {
            deSerialize();
            var rec = FindById(emp.EmpId);
            rec.Name = emp.Name;
            rec.Address = emp.Address;
            rec.Salary = emp.Salary;
            serialize();
        }
    }
    class AssignmentOnSerialiZation 
    {
        static EmployeeActivities EmpActivities = new EmployeeActivities();
       static Day11.Employee emp = new Day11.Employee();
        static string Menu = "----------------------Employee Application---------------------\nAdd Employee ------------ Press 1\nDelete Employee ------------ Press 2\nUpdate Employee ------------ Press 3\nFind Employee  By Id ------------ Press 4\nFind Employee  By Address ------------ Press 5\nFind Employee  By Name ------------ Press 6";
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                var choice = HelperClass.GetNumber(Menu);
                processing = ProcessMenu(choice);
            } while (processing);
        }

        private static bool ProcessMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    CreateEmployee();
                    return true;
                case 2:
                    deleteEmployee();
                    return true;
                case 3:
                    UpdateEmployee();
                    return true;
                case 4:
                    FindEmployeeByID();
                    return true;
                case 5:
                    FindEmployeeByAddress();
                    return true;
                case 6:
                    FindEmployeeByName();
                    return true;

            }
            return false;
        }

        private static void FindEmployeeByName()
        {
            string name = HelperClass.GetString("Enter Employee Name For Find That Employee");
            EmpActivities.FindByName(name);
        }

        private static void FindEmployeeByAddress()
        {
            string Address = HelperClass.GetString("Enter Employee Address For Find That Employee");
            EmpActivities.FindByAddress(Address);
        }

        private static void FindEmployeeByID()
        {
            int id = HelperClass.GetNumber("Enter Employee Id For Find That Employee");
            EmpActivities.FindById(id);
        }

        private static void UpdateEmployee()
        {
            emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
            emp.Name = HelperClass.GetString("Enter Employee Name");
            emp.Address = HelperClass.GetString("Enter Employee Address");
            emp.Salary = HelperClass.GetNumber("Enter Employee Salary");
            EmpActivities.UpdateEmployee(emp);
        }

        private static void deleteEmployee()
        {
            int id = HelperClass.GetNumber("Enter Employee Id For Delete That Employee");
            EmpActivities.DeleteEmployee(id);
        }

        private static void CreateEmployee()
        {
            emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
            emp.Name = HelperClass.GetString("Enter Employee Name");
            emp.Address = HelperClass.GetString("Enter Employee Address");
            emp.Salary = HelperClass.GetNumber("Enter Employee Salary");
            EmpActivities.AddNewEmployee(emp);
        }
    }
}
